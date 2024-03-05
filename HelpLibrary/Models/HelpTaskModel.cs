using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLibrary.Models
{
    public class HelpTaskModel
    {
        /// <summary>
        /// List of tasks that can be randomly given to the user.
        /// </summary>
        List<string> Tasks = new List<string>();

        /// <summary>
        /// List of quotes that can be used to cheer user up.
        /// </summary>
        List<string> Qutes = new List<string>();
    }
}
