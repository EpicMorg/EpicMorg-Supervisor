using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace EMSV.Api.DataTypes {

    public interface IDemonizedProcessBase {

        int Id { get; set; }
        string Name { get; set; }

    }

    public interface IDemonizedProcess : IDemonizedProcessBase {

        string Path { get; set; }
        string Arguments { get; set; }
        bool HideOnStart { get; set; }
        bool Autorestart { get; set; }
        ProcessPriorityClass Priority { get; set; }

    }

    public interface IPasswordedDemonizedProcess : IDemonizedProcess {

        string Key { get; set; }

    }

    public interface IRunningDemonizedProcess : IDemonizedProcess {
        int Restarts { get; set; }
        Status Status { get; }
        ProcessPriorityClass? CurrentPriority { get; set; }

    }

    public class DemonizedProcessBase : IDemonizedProcessBase {

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }

    }

    public class DemonizedProcess : DemonizedProcessBase, IDemonizedProcess {
        public virtual string Path { get; set; } = "";
        public virtual string Arguments { get; set; } = "";
        public virtual bool HideOnStart { get; set; }
        public virtual bool Autorestart { get; set; }
        public virtual ProcessPriorityClass Priority { get; set; } = ProcessPriorityClass.Normal;

    }

    public class PasswordedDemonizedProcess : DemonizedProcess, IPasswordedDemonizedProcess {
        public virtual string Key { get; set; }

    }

    public class RunningDemonizedProcess : DemonizedProcess, IRunningDemonizedProcess {

        public virtual int Restarts { get; set; }
        public virtual Status Status { get; set; }
        public virtual ProcessPriorityClass? CurrentPriority { get; set; }

    }

    public enum Status {

        NotRunning,
        Starting,
        Running,
        Stopping,
        Restarting,

    }

}