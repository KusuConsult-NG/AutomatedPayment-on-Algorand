using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomatedPaymentAlgorand.Services
{
    public interface IPaymentService
    {
        Task OneTimePayment();
        Task GroupedPayments();
    }
}
