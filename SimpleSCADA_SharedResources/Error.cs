using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleSCADA_SharedResources
{
    public class Error
    {
        #region Properties
        public int Id { get; private set; } //hier ID statt ErrorID
        public int? LogId { get; set; } // 1 to 1 with Log
        public Log? Log { get; set; } = null!; // 1 to 1 with Log
        public string Description { get; private set; }
        public ErrorType ErrorType { get; private set; }
        public ErrorSeverity Severity { get; private set; }
        public DateTime TimeOfOccurence { get; private set; }
        public DateTime TimeWhenFixed { get; private set; }
        #endregion

        #region Constructor
        public Error(string description, ErrorType errorType,
            ErrorSeverity severity, DateTime timeOfOccurence)
        {
            Description = description;
            ErrorType = errorType;
            Severity = severity;
            TimeOfOccurence = timeOfOccurence;
        }
        #endregion

        #region Methods

        #endregion

    }
}
