//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CountryPolicy
    {
        public int CountryID { get; set; }
        public decimal CitizenFee { get; set; }
        public decimal CitizenCompanyCost { get; set; }
        public decimal OrganisationCompanyCost { get; set; }
        public decimal NormalJobMarketFee { get; set; }
        public decimal ContractJobMarketFee { get; set; }
        public int MinimumContractLength { get; set; }
        public int MaximumContractLength { get; set; }
        public decimal NormalCongressVotingWinPercentage { get; set; }
        public decimal PartyFoundingFee { get; set; }
        public int PartyPresidentCadenceLength { get; set; }
        public int CongressCadenceLength { get; set; }
        public int CongressVotingLength { get; set; }
        public int PresidentCadenceLength { get; set; }
        public decimal OrganisationCreateCost { get; set; }
        public decimal MarketOfferCost { get; set; }
        public decimal NewspaperCreateCost { get; set; }
        public decimal ArticleTax { get; set; }
        public decimal MonetaryTaxRate { get; set; }
        public decimal MinimumMonetaryTax { get; set; }
        public int TreasuryVisibilityLawAllowHolderID { get; set; }
        public int CountryCompanyBuildLawAllowHolder { get; set; }
        public decimal MinimalWage { get; set; }
        public decimal HouseTax { get; set; }
        public decimal HotelTax { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual LawAllowHolder LawAllowHolder { get; set; }
        public virtual LawAllowHolder LawAllowHolder1 { get; set; }
    }
}
