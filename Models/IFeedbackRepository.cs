using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyspieShop.Models
{
   public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
