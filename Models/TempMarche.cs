using System;
using System.Collections.Generic;

namespace RestApiEcom.Models
{
    public partial class TempMarche
    {
        public int TempId { get; set; }
        public string TempCommune { get; set; }
        public string TempQuartier { get; set; }
        public string TempIlot { get; set; }
        public string TempLot { get; set; }
        public int? TempCntig { get; set; }
        public int? TempNumeroFiche { get; set; }
        public string TempNumeroCntig { get; set; }
        public int? TempNiveau { get; set; }
        public string TempNumeroRangee { get; set; }
        public string TempNumeroMairie { get; set; }
        public string TempCodeActivite { get; set; }
        public string TempArticleVendu { get; set; }
        public int? TempOccupationDate { get; set; }
        public int? TempOccupationJour { get; set; }
        public int? TempOccupationMois { get; set; }
        public int? TempOccupationAnnee { get; set; }
        public int? TempTaxeJourMontant { get; set; }
        public string TempTaxeAutre1Libelle { get; set; }
        public int? TempTaxeAutre1Montant { get; set; }
        public string TempTaxeAutre1Periodicite { get; set; }
        public string TempTaxeAutre2Libelle { get; set; }
        public int? TempTaxeAutre2Montant { get; set; }
        public string TempTaxeAutre2Periodicite { get; set; }
        public string TempTaxeAutre3Libelle { get; set; }
        public int? TempTaxeAutre3Montant { get; set; }
        public string TempTaxeAutre3Periodicite { get; set; }
        public string TempEnseigneType { get; set; }
        public string TempEnseigneLibelle { get; set; }
        public string TempTableProprietaireNom { get; set; }
        public string TempTableProprietaireGenre { get; set; }
        public string TempTableProprietaireNationalite { get; set; }
        public string TempTableProprietaireNaturePiece { get; set; }
        public string TempTableProprietaireNumeroPiece { get; set; }
        public string TempProprietaireNom { get; set; }
        public string TempProprietaireGenre { get; set; }
        public string TempProprietaireNationalite { get; set; }
        public string TempProprietairePieceNature { get; set; }
        public string TempProprietairePieceNumero { get; set; }
        public string TempEnqueteurEquipe { get; set; }
        public string TempEnqueteurNom { get; set; }
        public string TempEnqueteDate { get; set; }
        public int? TempEnqueteJour { get; set; }
        public int? TempEnqueteMois { get; set; }
        public int? TempEnqueteAnnee { get; set; }
        public string TempMarche1 { get; set; }
        public byte[] TempMerge { get; set; }
        public string TempStatut { get; set; }
        public bool TempBUsed { get; set; }
        public int? TempIdActivite { get; set; }
    }
}
