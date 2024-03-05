using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLibrary.Models
{
    public class JournalModel
    {
        /// <summary>
        /// List of Journal Entries that were added by the user.
        /// </summary>
        List<JournalEntryModel> entries = new List<JournalEntryModel>();
    }
}
