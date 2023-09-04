using System.IO;
using System.Web.Mvc;

namespace Phase3Section2._3.Controllers
{
    internal class ErrorViewModel : IView
    {
        public object RequestId { get; set; }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            throw new System.NotImplementedException();
        }
    }
}