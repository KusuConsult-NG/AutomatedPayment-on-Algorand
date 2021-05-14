using AutomatedPaymentAlgorand.Services;
using System.Threading.Tasks;

namespace AutomatedPaymentAlgorand
{
    public class Job
    {
        private readonly IPaymentService _payments;

        public Job(IPaymentService payments)
        {
            _payments = payments;
        }
        public Task OneTimePaymentJobAsync()
        {
            var result = _payments.OneTimePayment();
            return result;
        }

        public Task GroupedPaymentsJobAsnyc()
        {
            var result = _payments.GroupedPayments();
            return result;
        }
    }
}
