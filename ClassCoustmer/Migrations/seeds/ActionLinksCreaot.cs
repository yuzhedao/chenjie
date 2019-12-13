//using ClassCoustmer.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace CourManger.Migrations.Seeds
//{
//    public class ActionLinkCreator
//    {
//        private readonly ClassCoustmer.Models.ActionLinks _context;
//        public ActionLinkCreator(ClassCoustmer.Models.ActionLinks context)
//        {
//            _context = context;
//        }

//        public void Seed()
//        {
//            var initialActionLinks = new List<ActionLinks>
//            {
//                new ActionLinks
//                {
//                    Name="主页",
//                    Controller="Home",
//                    Action="Index"
//                }
//            };
//            foreach (var action in initialActionLinks)
//            {
//                if (_context.ActionLink.Any(r => r.Name == action.Name))
//                {
//                    continue;
//                }
//                _context.ActionLink.Add(action);
//            }
//        }
//    }

//    internal class ActionLink
//    {
//    }
//}