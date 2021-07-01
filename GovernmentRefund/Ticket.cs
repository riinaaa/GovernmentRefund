using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;

namespace GovernmentRefund
{
    public class Ticket
    {
        private String ticketNum = "0652129568057";
        private String fillename = "";
        private String ticketFull = "";
        private Boolean fop = false;
        private String DOI = null;
        private String couponStatus = null;
        private String fopString = "";
        private Boolean ticketval = false;
        private Boolean couponValid = false;
        private String ticketparsed = null;


        public Ticket(string ticketNum)
        {
            this.ticketNum = ticketNum;
        }

        public string TicketNum { get => ticketNum; set => ticketNum = value; }
        public string TicketFull { get => ticketFull; set => ticketFull = value; }
        public bool Fop { get => fop; set => fop = value; }
        public string DOI1 { get => DOI; set => DOI = value; }
        public string CouponStatus { get => couponStatus; set => couponStatus = value; }
        public string FopString { get => fopString; set => fopString = value; }
        public bool Ticketval { get => ticketval; set => ticketval = value; }
        public bool CouponValid { get => couponValid; set => couponValid = value; }
        public string Ticketparsed { get => ticketparsed; set => ticketparsed = value; }


        public string TktBlock()
        {
            // to locate the ticket (in which file)
            string[] MyFilesList = Directory.GetFiles(@"tickets\", "*.txt");
            List<string> FoundedSearch = new List<string>();
            foreach (string filename in MyFilesList)
            {
                string textFile = File.ReadAllText(filename);
                if (textFile.Contains(ticketNum))
                {
                    fillename = filename;
                }
            }
            string text = System.IO.File.ReadAllText(@"" + fillename);
            // to divide tickets
            string[] tickets = text.Split(new string[] { "\r\n\r\n" },
                               StringSplitOptions.RemoveEmptyEntries);

            // which ticket it the ticket we're looking for
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Contains(ticketNum))
                {
                    ticketFull = tickets[i];
                }
            }
            return ticketFull;
        }


        public string GetParsedTicket()
        {
            ticketFull = TktBlock();
            ticketparsed = ticketFull.Substring(ticketFull.IndexOf(ticketNum), 13);
            ticketval = (ticketparsed.Length == 13) && ticketparsed.StartsWith("065"); //CHECK

            if (ticketval == true)
            {
                return ticketparsed;
            }
            return "ERROR: TICKET INVALID";
        }


        public string GetFOP()
        {
            ticketFull = TktBlock();
            fop = ticketFull.Contains("FP GOV");
            if (fop == true)
            {
                fopString = "GOV";
            }
            return fopString;
        }

        public string GetDOI()
        {
            ticketFull = TktBlock();
            DOI = ticketFull.Substring(ticketFull.IndexOf("DOI-") + 4, 7).Trim();
            String Day = DOI.Substring(0, 2);
            String Month = DOI.Substring(2, 3).ToUpper();
            String Year = DOI.Substring(5, 2);
            String DOIFormatted = Day + "-" + Month + "-" + Year;
            //Console.WriteLine(DOIFormatted);
            DateTime myDate = DateTime.ParseExact(DOIFormatted, "dd-MMM-yy", CultureInfo.InvariantCulture);
            //Console.WriteLine(myDate.ToString());
            DateTime current = DateTime.Today;
            //Console.WriteLine(current.ToString());
            // date is not older than 3 years
            Boolean dateValid = myDate.AddYears(3) >= current; //CHECK
            //Console.WriteLine("Is DOI Valid? " + dateValid);

            if (dateValid == true)
            {
                return myDate + "";
            }
            return "ERROR: DATE IS INVALID";
        }

        public string GetCoupon()
        {
            ticketFull = TktBlock();
            couponStatus = ticketFull.Substring(ticketFull.IndexOf("OK") + 10, 10).Trim();
            if (couponStatus.Equals("A") || couponStatus.Equals("O"))
            {
                couponValid = true; //CHECK
                return couponStatus;
            }

            return "ERROR: COUPON INVALID";
        }
    }
}