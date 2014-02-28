﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18449
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestsUnitairesService.cs.ServiceReferenceQuidditch {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceQuidditch.IServiceQuidditch")]
    public interface IServiceQuidditch {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/CreateUser", ReplyAction="http://tempuri.org/IServiceQuidditch/CreateUserResponse")]
        void CreateUser(string inLogin, string inPasswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/CreateUser", ReplyAction="http://tempuri.org/IServiceQuidditch/CreateUserResponse")]
        System.Threading.Tasks.Task CreateUserAsync(string inLogin, string inPasswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/CheckUser", ReplyAction="http://tempuri.org/IServiceQuidditch/CheckUserResponse")]
        bool CheckUser(string inLogin, string inPasswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/CheckUser", ReplyAction="http://tempuri.org/IServiceQuidditch/CheckUserResponse")]
        System.Threading.Tasks.Task<bool> CheckUserAsync(string inLogin, string inPasswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllCoupes", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllCoupesResponse")]
        QuidditchService.SCoupe[] GetAllCoupes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllCoupes", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllCoupesResponse")]
        System.Threading.Tasks.Task<QuidditchService.SCoupe[]> GetAllCoupesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllEquipes", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllEquipesResponse")]
        QuidditchService.SEquipe[] GetAllEquipes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllEquipes", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllEquipesResponse")]
        System.Threading.Tasks.Task<QuidditchService.SEquipe[]> GetAllEquipesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetJoueursOfEquipe", ReplyAction="http://tempuri.org/IServiceQuidditch/GetJoueursOfEquipeResponse")]
        QuidditchService.SJoueur[] GetJoueursOfEquipe(QuidditchService.SEquipe inEquipe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetJoueursOfEquipe", ReplyAction="http://tempuri.org/IServiceQuidditch/GetJoueursOfEquipeResponse")]
        System.Threading.Tasks.Task<QuidditchService.SJoueur[]> GetJoueursOfEquipeAsync(QuidditchService.SEquipe inEquipe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllStades", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllStadesResponse")]
        QuidditchService.SStade[] GetAllStades();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllStades", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllStadesResponse")]
        System.Threading.Tasks.Task<QuidditchService.SStade[]> GetAllStadesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetMatchsOfCoupe", ReplyAction="http://tempuri.org/IServiceQuidditch/GetMatchsOfCoupeResponse")]
        QuidditchService.SMatch[] GetMatchsOfCoupe(QuidditchService.SCoupe inCoupe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetMatchsOfCoupe", ReplyAction="http://tempuri.org/IServiceQuidditch/GetMatchsOfCoupeResponse")]
        System.Threading.Tasks.Task<QuidditchService.SMatch[]> GetMatchsOfCoupeAsync(QuidditchService.SCoupe inCoupe);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetUtilisateur", ReplyAction="http://tempuri.org/IServiceQuidditch/GetUtilisateurResponse")]
        QuidditchService.SUtilisateur GetUtilisateur(string inLogin, string inPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetUtilisateur", ReplyAction="http://tempuri.org/IServiceQuidditch/GetUtilisateurResponse")]
        System.Threading.Tasks.Task<QuidditchService.SUtilisateur> GetUtilisateurAsync(string inLogin, string inPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/ReserverPlaces", ReplyAction="http://tempuri.org/IServiceQuidditch/ReserverPlacesResponse")]
        int ReserverPlaces(QuidditchService.SMatch inMatch, int inNbPlaces, QuidditchService.SSpectateur inSpect);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/ReserverPlaces", ReplyAction="http://tempuri.org/IServiceQuidditch/ReserverPlacesResponse")]
        System.Threading.Tasks.Task<int> ReserverPlacesAsync(QuidditchService.SMatch inMatch, int inNbPlaces, QuidditchService.SSpectateur inSpect);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetSpectateurById", ReplyAction="http://tempuri.org/IServiceQuidditch/GetSpectateurByIdResponse")]
        QuidditchService.SSpectateur GetSpectateurById(int inIdSpec);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetSpectateurById", ReplyAction="http://tempuri.org/IServiceQuidditch/GetSpectateurByIdResponse")]
        System.Threading.Tasks.Task<QuidditchService.SSpectateur> GetSpectateurByIdAsync(int inIdSpec);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetMatchById", ReplyAction="http://tempuri.org/IServiceQuidditch/GetMatchByIdResponse")]
        QuidditchService.SMatch GetMatchById(int inIdMatch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetMatchById", ReplyAction="http://tempuri.org/IServiceQuidditch/GetMatchByIdResponse")]
        System.Threading.Tasks.Task<QuidditchService.SMatch> GetMatchByIdAsync(int inIdMatch);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllMatchs", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllMatchsResponse")]
        QuidditchService.SMatch[] GetAllMatchs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllMatchs", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllMatchsResponse")]
        System.Threading.Tasks.Task<QuidditchService.SMatch[]> GetAllMatchsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllSpectators", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllSpectatorsResponse")]
        QuidditchService.SSpectateur[] GetAllSpectators();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllSpectators", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllSpectatorsResponse")]
        System.Threading.Tasks.Task<QuidditchService.SSpectateur[]> GetAllSpectatorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllReservations", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllReservationsResponse")]
        QuidditchService.SReservation[] GetAllReservations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/GetAllReservations", ReplyAction="http://tempuri.org/IServiceQuidditch/GetAllReservationsResponse")]
        System.Threading.Tasks.Task<QuidditchService.SReservation[]> GetAllReservationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/AnnulerReservation", ReplyAction="http://tempuri.org/IServiceQuidditch/AnnulerReservationResponse")]
        void AnnulerReservation(int inIdReservation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceQuidditch/AnnulerReservation", ReplyAction="http://tempuri.org/IServiceQuidditch/AnnulerReservationResponse")]
        System.Threading.Tasks.Task AnnulerReservationAsync(int inIdReservation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceQuidditchChannel : TestsUnitairesService.cs.ServiceReferenceQuidditch.IServiceQuidditch, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceQuidditchClient : System.ServiceModel.ClientBase<TestsUnitairesService.cs.ServiceReferenceQuidditch.IServiceQuidditch>, TestsUnitairesService.cs.ServiceReferenceQuidditch.IServiceQuidditch {
        
        public ServiceQuidditchClient() {
        }
        
        public ServiceQuidditchClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceQuidditchClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceQuidditchClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceQuidditchClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateUser(string inLogin, string inPasswd) {
            base.Channel.CreateUser(inLogin, inPasswd);
        }
        
        public System.Threading.Tasks.Task CreateUserAsync(string inLogin, string inPasswd) {
            return base.Channel.CreateUserAsync(inLogin, inPasswd);
        }
        
        public bool CheckUser(string inLogin, string inPasswd) {
            return base.Channel.CheckUser(inLogin, inPasswd);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUserAsync(string inLogin, string inPasswd) {
            return base.Channel.CheckUserAsync(inLogin, inPasswd);
        }
        
        public QuidditchService.SCoupe[] GetAllCoupes() {
            return base.Channel.GetAllCoupes();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SCoupe[]> GetAllCoupesAsync() {
            return base.Channel.GetAllCoupesAsync();
        }
        
        public QuidditchService.SEquipe[] GetAllEquipes() {
            return base.Channel.GetAllEquipes();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SEquipe[]> GetAllEquipesAsync() {
            return base.Channel.GetAllEquipesAsync();
        }
        
        public QuidditchService.SJoueur[] GetJoueursOfEquipe(QuidditchService.SEquipe inEquipe) {
            return base.Channel.GetJoueursOfEquipe(inEquipe);
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SJoueur[]> GetJoueursOfEquipeAsync(QuidditchService.SEquipe inEquipe) {
            return base.Channel.GetJoueursOfEquipeAsync(inEquipe);
        }
        
        public QuidditchService.SStade[] GetAllStades() {
            return base.Channel.GetAllStades();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SStade[]> GetAllStadesAsync() {
            return base.Channel.GetAllStadesAsync();
        }
        
        public QuidditchService.SMatch[] GetMatchsOfCoupe(QuidditchService.SCoupe inCoupe) {
            return base.Channel.GetMatchsOfCoupe(inCoupe);
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SMatch[]> GetMatchsOfCoupeAsync(QuidditchService.SCoupe inCoupe) {
            return base.Channel.GetMatchsOfCoupeAsync(inCoupe);
        }
        
        public QuidditchService.SUtilisateur GetUtilisateur(string inLogin, string inPassword) {
            return base.Channel.GetUtilisateur(inLogin, inPassword);
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SUtilisateur> GetUtilisateurAsync(string inLogin, string inPassword) {
            return base.Channel.GetUtilisateurAsync(inLogin, inPassword);
        }
        
        public int ReserverPlaces(QuidditchService.SMatch inMatch, int inNbPlaces, QuidditchService.SSpectateur inSpect) {
            return base.Channel.ReserverPlaces(inMatch, inNbPlaces, inSpect);
        }
        
        public System.Threading.Tasks.Task<int> ReserverPlacesAsync(QuidditchService.SMatch inMatch, int inNbPlaces, QuidditchService.SSpectateur inSpect) {
            return base.Channel.ReserverPlacesAsync(inMatch, inNbPlaces, inSpect);
        }
        
        public QuidditchService.SSpectateur GetSpectateurById(int inIdSpec) {
            return base.Channel.GetSpectateurById(inIdSpec);
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SSpectateur> GetSpectateurByIdAsync(int inIdSpec) {
            return base.Channel.GetSpectateurByIdAsync(inIdSpec);
        }
        
        public QuidditchService.SMatch GetMatchById(int inIdMatch) {
            return base.Channel.GetMatchById(inIdMatch);
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SMatch> GetMatchByIdAsync(int inIdMatch) {
            return base.Channel.GetMatchByIdAsync(inIdMatch);
        }
        
        public QuidditchService.SMatch[] GetAllMatchs() {
            return base.Channel.GetAllMatchs();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SMatch[]> GetAllMatchsAsync() {
            return base.Channel.GetAllMatchsAsync();
        }
        
        public QuidditchService.SSpectateur[] GetAllSpectators() {
            return base.Channel.GetAllSpectators();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SSpectateur[]> GetAllSpectatorsAsync() {
            return base.Channel.GetAllSpectatorsAsync();
        }
        
        public QuidditchService.SReservation[] GetAllReservations() {
            return base.Channel.GetAllReservations();
        }
        
        public System.Threading.Tasks.Task<QuidditchService.SReservation[]> GetAllReservationsAsync() {
            return base.Channel.GetAllReservationsAsync();
        }
        
        public void AnnulerReservation(int inIdReservation) {
            base.Channel.AnnulerReservation(inIdReservation);
        }
        
        public System.Threading.Tasks.Task AnnulerReservationAsync(int inIdReservation) {
            return base.Channel.AnnulerReservationAsync(inIdReservation);
        }
    }
}
