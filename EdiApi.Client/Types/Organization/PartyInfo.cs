﻿namespace SkbKontur.EdiApi.Client.Types.Organization
{
    public class PartyInfo
    {
        public string Gln { get; set; }

        public PartyAddress PartyAddress { get; set; }
        public GeoCoordinates GeoCoordinates { get; set; }
        public RussianPartyInfo RussianPartyInfo { get; set; }

        public BankAccount BankAccount { get; set; }

        public string SupplierCodeInBuyerSystem { get; set; }
        public string BusinessEntityMercuryId { get; set; }
        public string AreaEntityMercuryId { get; set; }
        public string FilialGln { get; set; }
        public ContactInformation Chief { get; set; }
        public ContactInformation Bookkeeper { get; set; }
        public ContactInformation SalesAdministration { get; set; }

        public ContactInformation OrderContact { get; set; }

        public string LocalizationType { get; set; }
        public bool UsesSimplifiedTaxSystem { get; set; }
    }
}