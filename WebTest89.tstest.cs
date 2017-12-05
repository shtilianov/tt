using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace new_test_project
{

    public class WebTest89 : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"Check all email messages received on Wednesday")]
        public void WebTest3_CodedStep()
        {
                        foreach (HtmlTableRow row in Pages.TelerikSample0.InboxTable.Rows)
                        {
            //                HtmlTableCell c = r.Cells[2]; // the date will always be in the third cell
                        
            //                if (c.TextContent.Contains("Wed"))
            //                {
            //                    HtmlTableCell c1 = r.Cells[0]; // look at the first cell in the row
            //                    HtmlControl checkb = c1.ChildNodes[0].As<HtmlControl>(); // find the checkbox within the cell
            //                    checkb.ScrollToVisible(); //Make sure we see the object before we click it
            //                    checkb.MouseClick();  // MouseClick rather than Click so any existing events will be fired
            //                }
                            
                            // the date will always be in the third cell of the table row
                            HtmlControl checkBox = FindElementHelper.FindControlInTableCell(row, "Wed");
                            
                            if (checkBox != null)
                            {
                                checkBox.ScrollToVisible(); //Make sure we see the object before we click it
                                checkBox.MouseClick();  // MouseClick rather than Click so any existing events will be fired
                            }
                        }                            
        }
    }
}
