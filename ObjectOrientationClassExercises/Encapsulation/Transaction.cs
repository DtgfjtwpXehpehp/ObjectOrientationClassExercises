using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientationClassExercises.Encapsulation
{
    internal class Transaction
    {
        public DateTime TransactionDateTime { get; set; }
        public decimal Amount { get; set; }
        public int MyProperty { get; set; }

        public string Description { get; set; }

        public string Reference { get; set; }

        public TransactionType TransactionType { get; set; }


    }
}
