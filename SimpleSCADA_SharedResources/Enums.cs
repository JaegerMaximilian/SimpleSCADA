using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSCADA_SharedResources
{
    public enum PlantState
    {
        RUNNING=1,
        DISTURBANCE,
        MAINTENANCE,
        PAUSED,
        IDLE,
        STOP,
        FINISHED,
    }

    public enum ErrorType 
    { 
        DATABASE=1, 
        OPC_UA,   
        DESKTOP_VIEW,
        THIS_IS_AN_ERROR,
    }

    public enum ErrorSeverity
    {
        CRITICAL=1,
        SHITTY,
        WARNING,
    }

    public enum UserRole
    {
        SUPERUSER=1,
        OPERATOR,
        SPECTATOR
    }

    public enum PasswordLevel
    {
        VeryLow = 0,
        Low = 1,
        Medium = 2,
        Strong = 3,
        VeryStrong = 4,

    }
}
