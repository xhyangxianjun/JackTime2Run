﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manager.JackTime2Run {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JackJob", Namespace="http://schemas.datacontract.org/2004/07/JackTime2Run")]
    [System.SerializableAttribute()]
    public partial class JackJob : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AppConfigField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CronField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JobTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogWhenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MethodField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NextDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ParasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SearchPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SrcCodeFilePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AppConfig {
            get {
                return this.AppConfigField;
            }
            set {
                if ((object.ReferenceEquals(this.AppConfigField, value) != true)) {
                    this.AppConfigField = value;
                    this.RaisePropertyChanged("AppConfig");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cron {
            get {
                return this.CronField;
            }
            set {
                if ((object.ReferenceEquals(this.CronField, value) != true)) {
                    this.CronField = value;
                    this.RaisePropertyChanged("Cron");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Enable {
            get {
                return this.EnableField;
            }
            set {
                if ((object.ReferenceEquals(this.EnableField, value) != true)) {
                    this.EnableField = value;
                    this.RaisePropertyChanged("Enable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JobType {
            get {
                return this.JobTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.JobTypeField, value) != true)) {
                    this.JobTypeField = value;
                    this.RaisePropertyChanged("JobType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastDate {
            get {
                return this.LastDateField;
            }
            set {
                if ((object.ReferenceEquals(this.LastDateField, value) != true)) {
                    this.LastDateField = value;
                    this.RaisePropertyChanged("LastDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LogWhen {
            get {
                return this.LogWhenField;
            }
            set {
                if ((object.ReferenceEquals(this.LogWhenField, value) != true)) {
                    this.LogWhenField = value;
                    this.RaisePropertyChanged("LogWhen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Method {
            get {
                return this.MethodField;
            }
            set {
                if ((object.ReferenceEquals(this.MethodField, value) != true)) {
                    this.MethodField = value;
                    this.RaisePropertyChanged("Method");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NextDate {
            get {
                return this.NextDateField;
            }
            set {
                if ((object.ReferenceEquals(this.NextDateField, value) != true)) {
                    this.NextDateField = value;
                    this.RaisePropertyChanged("NextDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Paras {
            get {
                return this.ParasField;
            }
            set {
                if ((object.ReferenceEquals(this.ParasField, value) != true)) {
                    this.ParasField = value;
                    this.RaisePropertyChanged("Paras");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SearchPath {
            get {
                return this.SearchPathField;
            }
            set {
                if ((object.ReferenceEquals(this.SearchPathField, value) != true)) {
                    this.SearchPathField = value;
                    this.RaisePropertyChanged("SearchPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SrcCodeFilePath {
            get {
                return this.SrcCodeFilePathField;
            }
            set {
                if ((object.ReferenceEquals(this.SrcCodeFilePathField, value) != true)) {
                    this.SrcCodeFilePathField = value;
                    this.RaisePropertyChanged("SrcCodeFilePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="JackTime2Run.NamePipeSrv")]
    public interface NamePipeSrv {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/GetAllJobs", ReplyAction="http://tempuri.org/NamePipeSrv/GetAllJobsResponse")]
        Manager.JackTime2Run.JackJob[] GetAllJobs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/GetAllJobs", ReplyAction="http://tempuri.org/NamePipeSrv/GetAllJobsResponse")]
        System.Threading.Tasks.Task<Manager.JackTime2Run.JackJob[]> GetAllJobsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/EnableJob", ReplyAction="http://tempuri.org/NamePipeSrv/EnableJobResponse")]
        bool EnableJob(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/EnableJob", ReplyAction="http://tempuri.org/NamePipeSrv/EnableJobResponse")]
        System.Threading.Tasks.Task<bool> EnableJobAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/DisableJob", ReplyAction="http://tempuri.org/NamePipeSrv/DisableJobResponse")]
        bool DisableJob(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/DisableJob", ReplyAction="http://tempuri.org/NamePipeSrv/DisableJobResponse")]
        System.Threading.Tasks.Task<bool> DisableJobAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/RemoveJob", ReplyAction="http://tempuri.org/NamePipeSrv/RemoveJobResponse")]
        bool RemoveJob(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/RemoveJob", ReplyAction="http://tempuri.org/NamePipeSrv/RemoveJobResponse")]
        System.Threading.Tasks.Task<bool> RemoveJobAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/AddJob", ReplyAction="http://tempuri.org/NamePipeSrv/AddJobResponse")]
        bool AddJob(Manager.JackTime2Run.JackJob job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/AddJob", ReplyAction="http://tempuri.org/NamePipeSrv/AddJobResponse")]
        System.Threading.Tasks.Task<bool> AddJobAsync(Manager.JackTime2Run.JackJob job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/UpdateJob", ReplyAction="http://tempuri.org/NamePipeSrv/UpdateJobResponse")]
        bool UpdateJob(Manager.JackTime2Run.JackJob job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/UpdateJob", ReplyAction="http://tempuri.org/NamePipeSrv/UpdateJobResponse")]
        System.Threading.Tasks.Task<bool> UpdateJobAsync(Manager.JackTime2Run.JackJob job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/TriJob", ReplyAction="http://tempuri.org/NamePipeSrv/TriJobResponse")]
        bool TriJob(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/TriJob", ReplyAction="http://tempuri.org/NamePipeSrv/TriJobResponse")]
        System.Threading.Tasks.Task<bool> TriJobAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/TestConn", ReplyAction="http://tempuri.org/NamePipeSrv/TestConnResponse")]
        bool TestConn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NamePipeSrv/TestConn", ReplyAction="http://tempuri.org/NamePipeSrv/TestConnResponse")]
        System.Threading.Tasks.Task<bool> TestConnAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NamePipeSrvChannel : Manager.JackTime2Run.NamePipeSrv, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NamePipeSrvClient : System.ServiceModel.ClientBase<Manager.JackTime2Run.NamePipeSrv>, Manager.JackTime2Run.NamePipeSrv {
        
        public NamePipeSrvClient() {
        }
        
        public NamePipeSrvClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NamePipeSrvClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NamePipeSrvClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NamePipeSrvClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Manager.JackTime2Run.JackJob[] GetAllJobs() {
            return base.Channel.GetAllJobs();
        }
        
        public System.Threading.Tasks.Task<Manager.JackTime2Run.JackJob[]> GetAllJobsAsync() {
            return base.Channel.GetAllJobsAsync();
        }
        
        public bool EnableJob(string name) {
            return base.Channel.EnableJob(name);
        }
        
        public System.Threading.Tasks.Task<bool> EnableJobAsync(string name) {
            return base.Channel.EnableJobAsync(name);
        }
        
        public bool DisableJob(string name) {
            return base.Channel.DisableJob(name);
        }
        
        public System.Threading.Tasks.Task<bool> DisableJobAsync(string name) {
            return base.Channel.DisableJobAsync(name);
        }
        
        public bool RemoveJob(string name) {
            return base.Channel.RemoveJob(name);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveJobAsync(string name) {
            return base.Channel.RemoveJobAsync(name);
        }
        
        public bool AddJob(Manager.JackTime2Run.JackJob job) {
            return base.Channel.AddJob(job);
        }
        
        public System.Threading.Tasks.Task<bool> AddJobAsync(Manager.JackTime2Run.JackJob job) {
            return base.Channel.AddJobAsync(job);
        }
        
        public bool UpdateJob(Manager.JackTime2Run.JackJob job) {
            return base.Channel.UpdateJob(job);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateJobAsync(Manager.JackTime2Run.JackJob job) {
            return base.Channel.UpdateJobAsync(job);
        }
        
        public bool TriJob(string name) {
            return base.Channel.TriJob(name);
        }
        
        public System.Threading.Tasks.Task<bool> TriJobAsync(string name) {
            return base.Channel.TriJobAsync(name);
        }
        
        public bool TestConn() {
            return base.Channel.TestConn();
        }
        
        public System.Threading.Tasks.Task<bool> TestConnAsync() {
            return base.Channel.TestConnAsync();
        }
    }
}
