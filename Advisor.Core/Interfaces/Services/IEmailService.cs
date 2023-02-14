using Advisor.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor.Core.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
