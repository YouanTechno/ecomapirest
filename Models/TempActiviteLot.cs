using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TempActiviteLot
    {
        public int Id { get; set; }
        public string TmpCommuneLibelle { get; set; }
        public string TmpQuartierLibelle { get; set; }
        public string TmpIlot { get; set; }
        public string TmpLot { get; set; }
        public int? TmbNumCntig { get; set; }
        public int? TmpNumFiche { get; set; }
        public int? TmpNumCntig { get; set; }
        public string TmpNumMairie { get; set; }
        public string TmpCodeActivite { get; set; }
        public string TmpArticleActivite { get; set; }
        public int? TmpDateOccupAnnee { get; set; }
        public int? TmpDateOccupJour { get; set; }
        public int? TmpDateOccupMois { get; set; }
        public int? TmpDateOccupAn { get; set; }
        public int? TmpTaxeJourMontant { get; set; }
        public string TmpTaxeAutre1 { get; set; }
        public int? TmpTaxeAutre1Montant { get; set; }
        public string TmpTaxeAutre1Periodicite { get; set; }
        public string TmpTaxeAutre2 { get; set; }
        public int? TmpTaxeAutre2Montant { get; set; }
        public string TmpTaxeAutre2Periodicite { get; set; }
        public string TmpTaxeAutre3 { get; set; }
        public int? TmpTaxeAutre3Montant { get; set; }
        public string TmpTaxeAutre3Periodicite { get; set; }
        public string TmpEnseigneType { get; set; }
        public string TmpEnseigneLibelle { get; set; }
        public string TmpNomPrenom { get; set; }
        public string TmpGenre { get; set; }
        public string TmpNationalite { get; set; }
        public string TmpPieceNature { get; set; }
        public string TmpPieceNumero { get; set; }
        public bool TmpBUsed { get; set; }
        public int? TmbIdActivite { get; set; }
    }
}
