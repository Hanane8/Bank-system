using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Transaction
    {
       
        private decimal depositAmount;
        private DateTime now;

        public string Type { get; set; }
        public string SenderAccountNumber { get; }
        public string ReceiverAccountNumber { get; }
        public decimal Amount { get; }
        public string OCRNumber { get; }
        public DateTime OperationDate { get; }

        public Transaction(string type, decimal amount, DateTime operationDate, string senderAccountNumber = null, string receiverAccountNumber = null, string ocrNumber = null)
        {
            Type = type;
            SenderAccountNumber = senderAccountNumber;
            ReceiverAccountNumber = receiverAccountNumber;
            Amount = amount;
            OCRNumber = ocrNumber;
            OperationDate = operationDate;
        }

       
    }
}
