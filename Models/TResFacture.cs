using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TResFacture
    {
        public TResFacture()
        {
            TResCollecte = new HashSet<TResCollecte>();
            TResPaiement = new HashSet<TResPaiement>();
            TResRFactureMetafacture = new HashSet<TResRFactureMetafacture>();
        }

        public int FactId { get; set; }
        public string FactCode { get; set; }
        public int FactTaxactId { get; set; }
        public int? FactContId { get; set; }
        public int? FactActId { get; set; }
        public int? FactCpteId { get; set; }
        public float? FactMontant { get; set; }
        public DateTime? FactPeriodeDebut { get; set; }
        public DateTime? FactPeriodeFin { get; set; }
        public DateTime? FactDateEmission { get; set; }
        public DateTime? FactDateEcheance { get; set; }
        public bool FactBEtatReglement { get; set; }
        public string FactLibelle { get; set; }
        public bool FactBAbandon { get; set; }
        public DateTime? FactDateaBandon { get; set; }
        public int? FactAbandonAgId { get; set; }
        public string FactAbandonMotif { get; set; }
        public int? FactPotentiel { get; set; }

        public virtual TResActivite FactAct { get; set; }
        public virtual TCContribuable FactCont { get; set; }
        public virtual TResTaxeactivite FactTaxact { get; set; }
        public virtual ICollection<TResCollecte> TResCollecte { get; set; }
        public virtual ICollection<TResPaiement> TResPaiement { get; set; }
        public virtual ICollection<TResRFactureMetafacture> TResRFactureMetafacture { get; set; }
    }
}
