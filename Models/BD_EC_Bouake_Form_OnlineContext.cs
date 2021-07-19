using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RestApiEcom.Models
{
    public partial class BD_EC_Bouake_Form_OnlineContext : DbContext
    {
       

        public BD_EC_Bouake_Form_OnlineContext(DbContextOptions<BD_EC_Bouake_Form_OnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pa> Pa { get; set; }
        public virtual DbSet<TActivite> TActivite { get; set; }
        public virtual DbSet<TAgent> TAgent { get; set; }
        public virtual DbSet<TAgentCollecteur> TAgentCollecteur { get; set; }
        public virtual DbSet<TCBatiment> TCBatiment { get; set; }
        public virtual DbSet<TCConservationFonciere> TCConservationFonciere { get; set; }
        public virtual DbSet<TCContribuable> TCContribuable { get; set; }
        public virtual DbSet<TCNatureOccupation> TCNatureOccupation { get; set; }
        public virtual DbSet<TCPieceIdentite> TCPieceIdentite { get; set; }
        public virtual DbSet<TCProprietaireEntreprise> TCProprietaireEntreprise { get; set; }
        public virtual DbSet<TCProprietaireOrdinaire> TCProprietaireOrdinaire { get; set; }
        public virtual DbSet<TCZoneInfos> TCZoneInfos { get; set; }
        public virtual DbSet<TCarte> TCarte { get; set; }
        public virtual DbSet<TCategorie> TCategorie { get; set; }
        public virtual DbSet<TCategorieIndicateur> TCategorieIndicateur { get; set; }
        public virtual DbSet<TComVille> TComVille { get; set; }
        public virtual DbSet<TComVilleQuartier> TComVilleQuartier { get; set; }
        public virtual DbSet<TConfiguration> TConfiguration { get; set; }
        public virtual DbSet<TConfigurationDashboard> TConfigurationDashboard { get; set; }
        public virtual DbSet<TConfigurationSecurite> TConfigurationSecurite { get; set; }
        public virtual DbSet<TDashboardRecettePaiement> TDashboardRecettePaiement { get; set; }
        public virtual DbSet<TDroit> TDroit { get; set; }
        public virtual DbSet<TECandidat> TECandidat { get; set; }
        public virtual DbSet<TECentreElectoral> TECentreElectoral { get; set; }
        public virtual DbSet<TEEcheanceElectoral> TEEcheanceElectoral { get; set; }
        public virtual DbSet<TEIncident> TEIncident { get; set; }
        public virtual DbSet<TERegroupementPolitique> TERegroupementPolitique { get; set; }
        public virtual DbSet<TErreur> TErreur { get; set; }
        public virtual DbSet<TEspaceType> TEspaceType { get; set; }
        public virtual DbSet<TEspacemarche> TEspacemarche { get; set; }
        public virtual DbSet<TFacturePeriodiqueTemp> TFacturePeriodiqueTemp { get; set; }
        public virtual DbSet<TGeneratorId> TGeneratorId { get; set; }
        public virtual DbSet<TIaIndicateur> TIaIndicateur { get; set; }
        public virtual DbSet<TIaIndicateurAssocie> TIaIndicateurAssocie { get; set; }
        public virtual DbSet<TImageDiapo> TImageDiapo { get; set; }
        public virtual DbSet<TIncident> TIncident { get; set; }
        public virtual DbSet<TIndicateur> TIndicateur { get; set; }
        public virtual DbSet<TMail> TMail { get; set; }
        public virtual DbSet<TMailAgent> TMailAgent { get; set; }
        public virtual DbSet<TMarche> TMarche { get; set; }
        public virtual DbSet<TModule> TModule { get; set; }
        public virtual DbSet<TNationalite> TNationalite { get; set; }
        public virtual DbSet<TOperateur> TOperateur { get; set; }
        public virtual DbSet<TOperation> TOperation { get; set; }
        public virtual DbSet<TPAnnee> TPAnnee { get; set; }
        public virtual DbSet<TPAnneeFonds> TPAnneeFonds { get; set; }
        public virtual DbSet<TPAnnees> TPAnnees { get; set; }
        public virtual DbSet<TPBailleur> TPBailleur { get; set; }
        public virtual DbSet<TPCategorie> TPCategorie { get; set; }
        public virtual DbSet<TPDepenses> TPDepenses { get; set; }
        public virtual DbSet<TPEtapeProjet> TPEtapeProjet { get; set; }
        public virtual DbSet<TPMaitreOeuvre> TPMaitreOeuvre { get; set; }
        public virtual DbSet<TPMaitreOuvrage> TPMaitreOuvrage { get; set; }
        public virtual DbSet<TPPhaseProjet> TPPhaseProjet { get; set; }
        public virtual DbSet<TPPrestataire> TPPrestataire { get; set; }
        public virtual DbSet<TPProgrammeTriennal> TPProgrammeTriennal { get; set; }
        public virtual DbSet<TPProjet> TPProjet { get; set; }
        public virtual DbSet<TPRMontant> TPRMontant { get; set; }
        public virtual DbSet<TPRProgTriennalAnnee> TPRProgTriennalAnnee { get; set; }
        public virtual DbSet<TPRProgrammeProjet> TPRProgrammeProjet { get; set; }
        public virtual DbSet<TPRProgrammeProjetAnnee> TPRProgrammeProjetAnnee { get; set; }
        public virtual DbSet<TPRProjetZone> TPRProjetZone { get; set; }
        public virtual DbSet<TPTache> TPTache { get; set; }
        public virtual DbSet<TPTacheRealiser> TPTacheRealiser { get; set; }
        public virtual DbSet<TPotentiel> TPotentiel { get; set; }
        public virtual DbSet<TProprietaire> TProprietaire { get; set; }
        public virtual DbSet<TQuartierParcelle> TQuartierParcelle { get; set; }
        public virtual DbSet<TRAgentModuleDroit> TRAgentModuleDroit { get; set; }
        public virtual DbSet<TRCBatimentContribuable> TRCBatimentContribuable { get; set; }
        public virtual DbSet<TRCZoneInfoProprietaireEntreprise> TRCZoneInfoProprietaireEntreprise { get; set; }
        public virtual DbSet<TRCZoneInfoProprietaireOrdinaire> TRCZoneInfoProprietaireOrdinaire { get; set; }
        public virtual DbSet<TREInfoEcheanceCentre> TREInfoEcheanceCentre { get; set; }
        public virtual DbSet<TREResulatObtenuCentre> TREResulatObtenuCentre { get; set; }
        public virtual DbSet<TRSonQuestionpopulation> TRSonQuestionpopulation { get; set; }
        public virtual DbSet<TReferencePropriete> TReferencePropriete { get; set; }
        public virtual DbSet<TResActivite> TResActivite { get; set; }
        public virtual DbSet<TResActivitecontribuable> TResActivitecontribuable { get; set; }
        public virtual DbSet<TResAvoir> TResAvoir { get; set; }
        public virtual DbSet<TResCollecte> TResCollecte { get; set; }
        public virtual DbSet<TResEspaceExploitable> TResEspaceExploitable { get; set; }
        public virtual DbSet<TResFacture> TResFacture { get; set; }
        public virtual DbSet<TResMetafacture> TResMetafacture { get; set; }
        public virtual DbSet<TResPaiement> TResPaiement { get; set; }
        public virtual DbSet<TResRFactureMetafacture> TResRFactureMetafacture { get; set; }
        public virtual DbSet<TResReferencement> TResReferencement { get; set; }
        public virtual DbSet<TResTaxactiviteDefaut> TResTaxactiviteDefaut { get; set; }
        public virtual DbSet<TResTaxassiete> TResTaxassiete { get; set; }
        public virtual DbSet<TResTaxcompte> TResTaxcompte { get; set; }
        public virtual DbSet<TResTaxe> TResTaxe { get; set; }
        public virtual DbSet<TResTaxeFamille> TResTaxeFamille { get; set; }
        public virtual DbSet<TResTaxeactivite> TResTaxeactivite { get; set; }
        public virtual DbSet<TResTaxeactiviteDefaut> TResTaxeactiviteDefaut { get; set; }
        public virtual DbSet<TResTaxperiodicite> TResTaxperiodicite { get; set; }
        public virtual DbSet<TResTaxvaleur> TResTaxvaleur { get; set; }
        public virtual DbSet<TResTypeActivite> TResTypeActivite { get; set; }
        public virtual DbSet<TResTypeLocal> TResTypeLocal { get; set; }
        public virtual DbSet<TSCamera> TSCamera { get; set; }
        public virtual DbSet<TSContCategorie> TSContCategorie { get; set; }
        public virtual DbSet<TSContContravention> TSContContravention { get; set; }
        public virtual DbSet<TSContMontant> TSContMontant { get; set; }
        public virtual DbSet<TSContSouscategorie> TSContSouscategorie { get; set; }
        public virtual DbSet<TSContValeur> TSContValeur { get; set; }
        public virtual DbSet<TSIncCategorie> TSIncCategorie { get; set; }
        public virtual DbSet<TSIncIncident> TSIncIncident { get; set; }
        public virtual DbSet<TSIncRepresentation> TSIncRepresentation { get; set; }
        public virtual DbSet<TSonPopulation> TSonPopulation { get; set; }
        public virtual DbSet<TSonProfession> TSonProfession { get; set; }
        public virtual DbSet<TSonQuestion> TSonQuestion { get; set; }
        public virtual DbSet<TSonSondage> TSonSondage { get; set; }
        public virtual DbSet<TTempValeurUnused> TTempValeurUnused { get; set; }
        public virtual DbSet<TTraces> TTraces { get; set; }
        public virtual DbSet<TTypePiece> TTypePiece { get; set; }
        public virtual DbSet<TVActiviteAnalyseNationalite> TVActiviteAnalyseNationalite { get; set; }
        public virtual DbSet<TVRecouvrementCarte> TVRecouvrementCarte { get; set; }
        public virtual DbSet<TVResCollecteRealisee> TVResCollecteRealisee { get; set; }
        public virtual DbSet<TVResFacture> TVResFacture { get; set; }
        public virtual DbSet<TVResFactureDashboard> TVResFactureDashboard { get; set; }
        public virtual DbSet<TVResFactureSoldee> TVResFactureSoldee { get; set; }
        public virtual DbSet<TVResRecette> TVResRecette { get; set; }
        public virtual DbSet<TVZone> TVZone { get; set; }
        public virtual DbSet<TValeurIndicateurZone> TValeurIndicateurZone { get; set; }
        public virtual DbSet<TZone> TZone { get; set; }
        public virtual DbSet<TZoneCaracteristique> TZoneCaracteristique { get; set; }
        public virtual DbSet<TZoneCaracteristiquePresence> TZoneCaracteristiquePresence { get; set; }
        public virtual DbSet<TZoneCategorie> TZoneCategorie { get; set; }
        public virtual DbSet<TZonePropriete> TZonePropriete { get; set; }
        public virtual DbSet<TZoneSecteur> TZoneSecteur { get; set; }
        public virtual DbSet<TZoneType> TZoneType { get; set; }
        public virtual DbSet<TZoneinfoZonepropriete> TZoneinfoZonepropriete { get; set; }
        public virtual DbSet<TempActiviteLot> TempActiviteLot { get; set; }
        public virtual DbSet<TempActiviteTaxeOfficiel> TempActiviteTaxeOfficiel { get; set; }
        public virtual DbSet<TempMarche> TempMarche { get; set; }
        public virtual DbSet<TempParcelaire> TempParcelaire { get; set; }
        public virtual DbSet<TempPotentiel> TempPotentiel { get; set; }
        public virtual DbSet<TempZone> TempZone { get; set; }
        public virtual DbSet<TempactiviteCodeActivite> TempactiviteCodeActivite { get; set; }
        public virtual DbSet<VActiviteAnalyseNationalite> VActiviteAnalyseNationalite { get; set; }
        public virtual DbSet<VActiviteNationalite> VActiviteNationalite { get; set; }
        public virtual DbSet<VComplementaire> VComplementaire { get; set; }
        public virtual DbSet<VContraventionValeur> VContraventionValeur { get; set; }
        public virtual DbSet<VContribuableActivteTaxeRetard> VContribuableActivteTaxeRetard { get; set; }
        public virtual DbSet<VContribuableQuartierNombre> VContribuableQuartierNombre { get; set; }
        public virtual DbSet<VDashboardFacture> VDashboardFacture { get; set; }
        public virtual DbSet<VDashboardQuartierTaxeDate> VDashboardQuartierTaxeDate { get; set; }
        public virtual DbSet<VECentreElectoral> VECentreElectoral { get; set; }
        public virtual DbSet<VEtatCollecte> VEtatCollecte { get; set; }
        public virtual DbSet<VEtatRecette> VEtatRecette { get; set; }
        public virtual DbSet<VFactureAnnee> VFactureAnnee { get; set; }
        public virtual DbSet<VFactureByQuartier> VFactureByQuartier { get; set; }
        public virtual DbSet<VFactureByQuartierMoisCourant> VFactureByQuartierMoisCourant { get; set; }
        public virtual DbSet<VFactureByQuartierRecouvert> VFactureByQuartierRecouvert { get; set; }
        public virtual DbSet<VFactureDerniereEcheanceReglee> VFactureDerniereEcheanceReglee { get; set; }
        public virtual DbSet<VFactureJournaliere> VFactureJournaliere { get; set; }
        public virtual DbSet<VFactureMois> VFactureMois { get; set; }
        public virtual DbSet<VFcatureByQuartierRecouvertMoisCourant> VFcatureByQuartierRecouvertMoisCourant { get; set; }
        public virtual DbSet<VProgrammeProjetAnnee> VProgrammeProjetAnnee { get; set; }
        public virtual DbSet<VProjetZone> VProjetZone { get; set; }
        public virtual DbSet<VProjetparquatier> VProjetparquatier { get; set; }
        public virtual DbSet<VQuartier> VQuartier { get; set; }
        public virtual DbSet<VRecettteMontant> VRecettteMontant { get; set; }
        public virtual DbSet<VRecouvrementCarte> VRecouvrementCarte { get; set; }
        public virtual DbSet<VResActiviteContribuable> VResActiviteContribuable { get; set; }
        public virtual DbSet<VResCollecteRealisee> VResCollecteRealisee { get; set; }
        public virtual DbSet<VResFacture> VResFacture { get; set; }
        public virtual DbSet<VResFactureDashboard> VResFactureDashboard { get; set; }
        public virtual DbSet<VResFactureSoldee> VResFactureSoldee { get; set; }
        public virtual DbSet<VResFactureTaxactRetard> VResFactureTaxactRetard { get; set; }
        public virtual DbSet<VResRecette> VResRecette { get; set; }
        public virtual DbSet<VRetardAgregats> VRetardAgregats { get; set; }
        public virtual DbSet<VRevenuParActivite> VRevenuParActivite { get; set; }
        public virtual DbSet<VTaxeQuartier> VTaxeQuartier { get; set; }
        public virtual DbSet<VTaxeQuartierRetard> VTaxeQuartierRetard { get; set; }
        public virtual DbSet<VTaxeZone> VTaxeZone { get; set; }
        public virtual DbSet<VTaxeZoneRetard> VTaxeZoneRetard { get; set; }
        public virtual DbSet<VZone> VZone { get; set; }
        public virtual DbSet<VZoneEauElectricite> VZoneEauElectricite { get; set; }
        public virtual DbSet<VZoneOccupationNombre> VZoneOccupationNombre { get; set; }
        public virtual DbSet<VZonePrimaire> VZonePrimaire { get; set; }

 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PA$");

                entity.Property(e => e.AdrMoral)
                    .HasColumnName("Adr_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.AdrOqpt)
                    .HasColumnName("Adr_oqpt")
                    .HasMaxLength(255);

                entity.Property(e => e.AdrPropr)
                    .HasColumnName("Adr_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.AvBitum)
                    .HasColumnName("Av_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.Avenue).HasMaxLength(255);

                entity.Property(e => e.Bld).HasMaxLength(255);

                entity.Property(e => e.BldBitum)
                    .HasColumnName("Bld_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.CmptEau).HasColumnName("Cmpt_eau");

                entity.Property(e => e.CmptElect).HasColumnName("Cmpt_elect");

                entity.Property(e => e.Commerce).HasMaxLength(255);

                entity.Property(e => e.Commune).HasMaxLength(255);

                entity.Property(e => e.CourComm)
                    .HasColumnName("Cour_comm")
                    .HasMaxLength(255);

                entity.Property(e => e.DateFinT)
                    .HasColumnName("Date_fin_t")
                    .HasMaxLength(255);

                entity.Property(e => e.DateObt)
                    .HasColumnName("Date_obt")
                    .HasMaxLength(255);

                entity.Property(e => e.DatePass)
                    .HasColumnName("Date_pass")
                    .HasMaxLength(255);

                entity.Property(e => e.DatePerm)
                    .HasColumnName("Date_perm")
                    .HasMaxLength(255);

                entity.Property(e => e.Duplex).HasMaxLength(255);

                entity.Property(e => e.Eau).HasMaxLength(255);

                entity.Property(e => e.EdifRelig)
                    .HasColumnName("Edif_relig")
                    .HasMaxLength(255);

                entity.Property(e => e.Elect).HasMaxLength(255);

                entity.Property(e => e.Enqueteur).HasMaxLength(255);

                entity.Property(e => e.Enquêté).HasMaxLength(255);

                entity.Property(e => e.Entrepot).HasMaxLength(255);

                entity.Property(e => e.Entrp).HasMaxLength(255);

                entity.Property(e => e.EtabAdmi)
                    .HasColumnName("Etab_admi")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabCult)
                    .HasColumnName("Etab_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabSanit)
                    .HasColumnName("Etab_sanit")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabScol)
                    .HasColumnName("Etab_scol")
                    .HasMaxLength(255);

                entity.Property(e => e.EtatVrie)
                    .HasColumnName("Etat_vrie")
                    .HasMaxLength(255);

                entity.Property(e => e.FrBornage)
                    .HasColumnName("Fr_bornage")
                    .HasMaxLength(255);

                entity.Property(e => e.HabitComm)
                    .HasColumnName("Habit_comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Habitat)
                    .HasColumnName("Habitat°")
                    .HasMaxLength(255);

                entity.Property(e => e.Hangar).HasMaxLength(255);

                entity.Property(e => e.HtatPrec)
                    .HasColumnName("Htat°_prec")
                    .HasMaxLength(255);

                entity.Property(e => e.Ilot).HasMaxLength(255);

                entity.Property(e => e.Immeuble).HasMaxLength(255);

                entity.Property(e => e.Indus).HasMaxLength(255);

                entity.Property(e => e.LCult)
                    .HasColumnName("L_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.Lot).HasMaxLength(255);

                entity.Property(e => e.Magasin).HasMaxLength(255);

                entity.Property(e => e.MaisonBde)
                    .HasColumnName("Maison_bde")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat1).HasColumnName("N_etg_bat1");

                entity.Property(e => e.NEtgBat2).HasColumnName("N_etg_bat2");

                entity.Property(e => e.NEtgBat3).HasColumnName("N_etg_bat3");

                entity.Property(e => e.NEtgBat4).HasColumnName("N_etg_bat4");

                entity.Property(e => e.NEtgBat5).HasColumnName("N_etg_bat5");

                entity.Property(e => e.NEtgBat6).HasColumnName("N_etg_bat6");

                entity.Property(e => e.NLtrAttr)
                    .HasColumnName("N°ltr_attr")
                    .HasMaxLength(255);

                entity.Property(e => e.NatPropr)
                    .HasColumnName("Nat_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.NatureLot)
                    .HasColumnName("Nature_lot")
                    .HasMaxLength(255);

                entity.Property(e => e.NbrBat).HasColumnName("Nbr_bat");

                entity.Property(e => e.NbrBouche)
                    .HasColumnName("Nbr_bouche")
                    .HasMaxLength(255);

                entity.Property(e => e.NoRegCom)
                    .HasColumnName("No_reg_com")
                    .HasMaxLength(255);

                entity.Property(e => e.NomOqpant)
                    .HasColumnName("Nom_oqpant")
                    .HasMaxLength(255);

                entity.Property(e => e.NomPropr)
                    .HasColumnName("Nom_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.ObsEnq)
                    .HasColumnName("Obs_enq")
                    .HasMaxLength(255);

                entity.Property(e => e.OperatIm)
                    .HasColumnName("Operat°_im")
                    .HasMaxLength(255);

                entity.Property(e => e.OqptLocat)
                    .HasColumnName("Oqpt_locat")
                    .HasMaxLength(255);

                entity.Property(e => e.PermConst)
                    .HasColumnName("Perm_const")
                    .HasMaxLength(255);

                entity.Property(e => e.PersMoral)
                    .HasColumnName("Pers_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecAdmi)
                    .HasColumnName("Prec_admi")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecCult)
                    .HasColumnName("Prec_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecEntrp)
                    .HasColumnName("Prec_entrp")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecHc)
                    .HasColumnName("Prec_hc")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecIndus)
                    .HasColumnName("Prec_indus")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecLcult)
                    .HasColumnName("Prec_Lcult")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSanit)
                    .HasColumnName("Prec_sanit")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecScol)
                    .HasColumnName("Prec_scol")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSecur)
                    .HasColumnName("Prec_secur")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSprt)
                    .HasColumnName("Prec_sprt")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecTpCm)
                    .HasColumnName("Prec_tp_cm")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecTrans)
                    .HasColumnName("Prec_trans")
                    .HasMaxLength(255);

                entity.Property(e => e.ProfPropr)
                    .HasColumnName("Prof_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.Promoteur).HasMaxLength(255);

                entity.Property(e => e.ProprPhys)
                    .HasColumnName("Propr_phys")
                    .HasMaxLength(255);

                entity.Property(e => e.PrénOqpan)
                    .HasColumnName("Prén_oqpan")
                    .HasMaxLength(255);

                entity.Property(e => e.PrénPropr)
                    .HasColumnName("Prén_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.Quartiers).HasMaxLength(255);

                entity.Property(e => e.RaisonSoc)
                    .HasColumnName("Raison_soc")
                    .HasMaxLength(255);

                entity.Property(e => e.ResidProp)
                    .HasColumnName("Resid_prop")
                    .HasMaxLength(255);

                entity.Property(e => e.Rue).HasMaxLength(255);

                entity.Property(e => e.RueBitum)
                    .HasColumnName("Rue_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.Securité).HasMaxLength(255);

                entity.Property(e => e.SiStaEss)
                    .HasColumnName("Si_sta_ess")
                    .HasMaxLength(255);

                entity.Property(e => e.Sprt).HasMaxLength(255);

                entity.Property(e => e.StatEss)
                    .HasColumnName("Stat°_ess")
                    .HasMaxLength(255);

                entity.Property(e => e.Supervis).HasMaxLength(255);

                entity.Property(e => e.TelMoral)
                    .HasColumnName("Tel_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.TelOqpt).HasColumnName("Tel_oqpt");

                entity.Property(e => e.TelPropr).HasColumnName("Tel_propr");

                entity.Property(e => e.Tf)
                    .HasColumnName("TF")
                    .HasMaxLength(255);

                entity.Property(e => e.Trans).HasMaxLength(255);

                entity.Property(e => e.Unité).HasMaxLength(255);

                entity.Property(e => e.Villa).HasMaxLength(255);
            });

            modelBuilder.Entity<TActivite>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("T_ACTIVITE");

                entity.Property(e => e.ActId)
                    .HasColumnName("ACT_ID")
                    .HasComment("identifiant de l'activité");

                entity.Property(e => e.ActActId).HasColumnName("ACT_ACT_ID");

                entity.Property(e => e.ActArticle)
                    .HasColumnName("ACT_ARTICLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("articles / services vendu");

                entity.Property(e => e.ActContId)
                    .HasColumnName("ACT_CONT_ID")
                    .HasComment("identifiant du contribuable associé à l'activité");

                entity.Property(e => e.ActDate)
                    .HasColumnName("ACT_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date de démarrage effectif de l'activité");

                entity.Property(e => e.ActEnseignId)
                    .HasColumnName("ACT_ENSEIGN_ID")
                    .HasComment("identifiant du type d'enseigne de l'activité");

                entity.Property(e => e.ActEnseignLibelle)
                    .HasColumnName("ACT_ENSEIGN_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé marqué sur l'enseigne de l'activité");

                entity.Property(e => e.ActEspmarchId)
                    .HasColumnName("ACT_ESPMARCH_ID")
                    .HasComment("identifiant de l'espace marché (table ou autre)");

                entity.Property(e => e.ActPlaque)
                    .HasColumnName("ACT_PLAQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant associé à l'activité par la mairie");

                entity.Property(e => e.ActProId)
                    .HasColumnName("ACT_PRO_ID")
                    .HasComment("identifiant du propriétaire de l'activité");

                entity.Property(e => e.ActTaId)
                    .HasColumnName("ACT_TA_ID")
                    .HasComment("Type Activité");

                entity.Property(e => e.ActZiId)
                    .HasColumnName("ACT_ZI_ID")
                    .HasComment("id de la zone a laquelle est éventuellement directement rattachée l'activité ");

                entity.HasOne(d => d.ActAct)
                    .WithMany(p => p.TActivite)
                    .HasForeignKey(d => d.ActActId)
                    .HasConstraintName("FK_T_ACTIVITE_T_RES_ACTIVITE");

                entity.HasOne(d => d.ActCont)
                    .WithMany(p => p.TActivite)
                    .HasForeignKey(d => d.ActContId)
                    .HasConstraintName("FK_T_ACTIVITE_T_C_ZONE_INFOS");

                entity.HasOne(d => d.ActEspmarch)
                    .WithMany(p => p.TActivite)
                    .HasForeignKey(d => d.ActEspmarchId)
                    .HasConstraintName("FK_T_ACTIVITE_T_ESPACEMARCHE");

                entity.HasOne(d => d.ActPro)
                    .WithMany(p => p.TActivite)
                    .HasForeignKey(d => d.ActProId)
                    .HasConstraintName("FK_T_ACTIVITE_T_PROPRIETAIRE");
            });

            modelBuilder.Entity<TAgent>(entity =>
            {
                entity.HasKey(e => e.AgId);

                entity.ToTable("T_Agent");

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de la table T_Agent");

                entity.Property(e => e.AgLogin)
                    .IsRequired()
                    .HasColumnName("AG_Login")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("nom d'utilisateur d'un agent");

                entity.Property(e => e.AgNom)
                    .HasColumnName("AG_Nom")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("nom d'un agent");

                entity.Property(e => e.AgPass)
                    .HasColumnName("AG_Pass")
                    .IsUnicode(false)
                    .HasComment("mot de passe crypté associé à un agent");

                entity.Property(e => e.AgPrenoms)
                    .HasColumnName("AG_Prenoms")
                    .IsUnicode(false)
                    .HasComment("Prénoms d'un agent");
            });

            modelBuilder.Entity<TAgentCollecteur>(entity =>
            {
                entity.HasKey(e => e.AcolId);

                entity.ToTable("T_AGENT_COLLECTEUR");

                entity.Property(e => e.AcolId)
                    .HasColumnName("ACOL_ID")
                    .HasComment("identifiant de l'agent collecteur");

                entity.Property(e => e.AcolAgId)
                    .HasColumnName("ACOL_AG_ID")
                    .HasComment("identifiant de l'utilisateur de l'application qui a créé l'agent collecteur");

                entity.Property(e => e.AcolBActif)
                    .HasColumnName("ACOL_bACTIF")
                    .HasComment("vrai indique que l'agent collecteur est actif (peut être utilisé dans l'application)");

                entity.Property(e => e.AcolDate)
                    .HasColumnName("ACOL_DATE")
                    .HasColumnType("date")
                    .HasComment("date de création de l'agent collecteur");

                entity.Property(e => e.AcolMatricule)
                    .HasColumnName("ACOL_MATRICULE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("le numéro matricule de l'agent collecteur");

                entity.Property(e => e.AcolNom)
                    .HasColumnName("ACOL_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nom de l'agent collecteur");

                entity.Property(e => e.AcolPrenom)
                    .HasColumnName("ACOL_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Prénom de l'agent collecteur");

                entity.Property(e => e.AcolSecteur)
                    .HasColumnName("ACOL_SECTEUR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la zone sous couverture de l'agent collecteur");

                entity.Property(e => e.AcolSecteurZoneId)
                    .HasColumnName("ACOL_SECTEUR_ZONE_ID")
                    .HasComment("identifiant de la zone géographique concernée");

                entity.HasOne(d => d.AcolAg)
                    .WithMany(p => p.TAgentCollecteur)
                    .HasForeignKey(d => d.AcolAgId)
                    .HasConstraintName("FK_T_AGENT_COLLECTEUR_T_Agent");
            });

            modelBuilder.Entity<TCBatiment>(entity =>
            {
                entity.HasKey(e => e.BatId)
                    .HasName("PK_T_C_BATIMENT");

                entity.ToTable("T_C_Batiment");

                entity.Property(e => e.BatId)
                    .HasColumnName("BAT_ID")
                    .HasComment("identifiant du bâtiment");

                entity.Property(e => e.BatAffectation)
                    .HasColumnName("BAT_AFFECTATION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("affectation du bâtiment");

                entity.Property(e => e.BatNatureCode)
                    .HasColumnName("BAT_NATURE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Code de la nature d'occupation");

                entity.Property(e => e.BatNbAppart)
                    .HasColumnName("BAT_NB_APPART")
                    .HasComment("nb d'ensemble de pièce (maison, appartement,...) exploitable dans le bâtiment");

                entity.Property(e => e.BatNiv)
                    .HasColumnName("BAT_NIV")
                    .HasComment("Nombre de niveau du bâtiment");

                entity.Property(e => e.BatZiId)
                    .HasColumnName("BAT_ZI_ID")
                    .HasComment("Identifiant de la zone géogrpahique (infos associées) concernée");

                entity.HasOne(d => d.BatNatureCodeNavigation)
                    .WithMany(p => p.TCBatiment)
                    .HasForeignKey(d => d.BatNatureCode)
                    .HasConstraintName("FK_T_C_Batiment_T_C_NatureOccupation");

                entity.HasOne(d => d.BatZi)
                    .WithMany(p => p.TCBatiment)
                    .HasForeignKey(d => d.BatZiId)
                    .HasConstraintName("FK_T_C_Batiment_T_C_ZONE_INFOS");
            });

            modelBuilder.Entity<TCConservationFonciere>(entity =>
            {
                entity.HasKey(e => e.CfCode);

                entity.ToTable("T_C_ConservationFonciere");

                entity.Property(e => e.CfCode)
                    .HasColumnName("CF_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code de la conservation foncière");

                entity.Property(e => e.CfDescription)
                    .HasColumnName("CF_DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("description de la conservation foncière");

                entity.Property(e => e.CfLivreFoncier)
                    .HasColumnName("CF_LIVRE_FONCIER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du livre foncier associé à la conservation foncière");
            });

            modelBuilder.Entity<TCContribuable>(entity =>
            {
                entity.HasKey(e => e.ContId);

                entity.ToTable("T_C_Contribuable");

                entity.HasIndex(e => e.ContId)
                    .HasName("IX_T_C_Contribuable")
                    .IsUnique();

                entity.Property(e => e.ContId)
                    .HasColumnName("CONT_ID")
                    .HasComment("identifiant du contribuable");

                entity.Property(e => e.ContDateCreation)
                    .HasColumnName("CONT_DATE_CREATION")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ContDateImmatriculation)
                    .HasColumnName("CONT_DATE_IMMATRICULATION")
                    .HasColumnType("date")
                    .HasComment("date d'immatriculation du contribuable");

                entity.Property(e => e.ContDateImmatriculationAnnuelle)
                    .HasColumnName("CONT_DATE_IMMATRICULATION_ANNUELLE")
                    .HasColumnType("date");

                entity.Property(e => e.ContMail)
                    .HasColumnName("CONT_MAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("adresse mail du contribuable");

                entity.Property(e => e.ContMatricule)
                    .HasColumnName("CONT_MATRICULE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("le matricule du contribuable");

                entity.Property(e => e.ContMatriculeAnnuel)
                    .HasColumnName("CONT_MATRICULE_ANNUEL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNatId)
                    .HasColumnName("CONT_NAT_ID")
                    .HasComment("identifiant de la nationalité du contribuable");

                entity.Property(e => e.ContNcc)
                    .HasColumnName("CONT_NCC")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("numéro de compte contribuable detenu par le contribuable");

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("nom du contribuable");

                entity.Property(e => e.ContNumPiece)
                    .HasColumnName("CONT_NUM_PIECE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContPieceCode)
                    .HasColumnName("CONT_PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("l'identifiant du type de pièce fourni par le  contribuable");

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("prénom du contribuable");

                entity.Property(e => e.ContTelephone)
                    .HasColumnName("CONT_TELEPHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("numéro de téléphone du contribuable");

                entity.HasOne(d => d.ContPieceCodeNavigation)
                    .WithMany(p => p.TCContribuable)
                    .HasForeignKey(d => d.ContPieceCode)
                    .HasConstraintName("FK_T_C_Contribuable_T_C_PieceIdentite");
            });

            modelBuilder.Entity<TCNatureOccupation>(entity =>
            {
                entity.HasKey(e => e.NatureCode);

                entity.ToTable("T_C_NatureOccupation");

                entity.Property(e => e.NatureCode)
                    .HasColumnName("NATURE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code de la nature d'occupation");

                entity.Property(e => e.NatureLibelle)
                    .HasColumnName("NATURE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé de la nature d'occupation");
            });

            modelBuilder.Entity<TCPieceIdentite>(entity =>
            {
                entity.HasKey(e => e.PieceCode);

                entity.ToTable("T_C_PieceIdentite");

                entity.Property(e => e.PieceCode)
                    .HasColumnName("PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Code du type de pièce d'identité (CNI,CP, ...)");

                entity.Property(e => e.PieceLibelle)
                    .HasColumnName("PIECE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du type de pièce d'identité (Carte Nationale d'Identité, Carte Professionnelle, ...)");
            });

            modelBuilder.Entity<TCProprietaireEntreprise>(entity =>
            {
                entity.HasKey(e => e.PeId);

                entity.ToTable("T_C_ProprietaireEntreprise");

                entity.Property(e => e.PeId)
                    .HasColumnName("PE_ID")
                    .HasComment("identifiant de l'enregistrement")
                    .ValueGeneratedNever();

                entity.Property(e => e.PeAddressePostale)
                    .HasColumnName("PE_ADDRESSE_POSTALE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("adresse postale de l'entreprise");

                entity.Property(e => e.PeFax)
                    .HasColumnName("PE_FAX")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("numéro de fax de l'entreprise");

                entity.Property(e => e.PeNcc)
                    .HasColumnName("PE_NCC")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("numéro du compte contribuable de l'entreprise");

                entity.Property(e => e.PeRaisonSociale)
                    .HasColumnName("PE_RAISON_SOCIALE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("nom de l'entreprise");

                entity.Property(e => e.PeTel)
                    .HasColumnName("PE_TEL")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("téléphone de l'entreprise");
            });

            modelBuilder.Entity<TCProprietaireOrdinaire>(entity =>
            {
                entity.HasKey(e => e.PoId);

                entity.ToTable("T_C_ProprietaireOrdinaire");

                entity.Property(e => e.PoId).HasColumnName("PO_ID");

                entity.Property(e => e.PoDateDelivrance)
                    .HasColumnName("PO_DATE_DELIVRANCE")
                    .HasColumnType("date")
                    .HasComment("date délivrance de la pièce d'identité du  propriétaire ordinaire");

                entity.Property(e => e.PoDateExpiration)
                    .HasColumnName("PO_DATE_EXPIRATION")
                    .HasColumnType("date")
                    .HasComment("date expiration de la pièce d'identité du propriétaire ordinaire");

                entity.Property(e => e.PoLieuDelivrance)
                    .HasColumnName("PO_LIEU_DELIVRANCE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("lieu de délivrance de la pièce d'identité du propriétaire ordinaire");

                entity.Property(e => e.PoNom)
                    .HasColumnName("PO_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nom du propriétaire ordinaire");

                entity.Property(e => e.PoNumPiece)
                    .HasColumnName("PO_NUM_PIECE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("le numéro de pièce d'identité du  propriétaire ordinaire");

                entity.Property(e => e.PoPieceCode)
                    .HasColumnName("PO_PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("l'identifiant du type de pièce fourni par le  propriétaire ordinaire");

                entity.Property(e => e.PoPrenom)
                    .HasColumnName("PO_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("prénom du propriétaire ordinaire");

                entity.HasOne(d => d.PoPieceCodeNavigation)
                    .WithMany(p => p.TCProprietaireOrdinaire)
                    .HasForeignKey(d => d.PoPieceCode)
                    .HasConstraintName("FK_T_C_ProprietaireOrdinaire_T_C_PieceIdentite");
            });

            modelBuilder.Entity<TCZoneInfos>(entity =>
            {
                entity.HasKey(e => e.ZiId)
                    .HasName("PK_T_ZONE_INFOS");

                entity.ToTable("T_C_ZONE_INFOS");

                entity.Property(e => e.ZiId)
                    .HasColumnName("ZI_ID")
                    .HasComment("Identifiant de l'enregistrement");

                entity.Property(e => e.BDelete).HasColumnName("bDelete");

                entity.Property(e => e.ZiBEau)
                    .HasColumnName("ZI_bEau")
                    .HasComment("indique si la zone bénéficie de la couverture d'eau potable");

                entity.Property(e => e.ZiBElec)
                    .HasColumnName("ZI_bElec")
                    .HasComment("indique si la zone bénéficie du réseau électrique");

                entity.Property(e => e.ZiIlot)
                    .HasColumnName("ZI_ILOT")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("l'ilot associé à la zone géographique indexée");

                entity.Property(e => e.ZiLot)
                    .HasColumnName("ZI_LOT")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("le lot associé à la zone géographique indexée");

                entity.Property(e => e.ZiNatureCode)
                    .HasColumnName("ZI_NATURE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Code de la nature d'occupation (peut être marché, espace commercial, zone industrielle, ...)");

                entity.Property(e => e.ZiParcelle)
                    .HasColumnName("ZI_PARCELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("la parcelle associée à la zone géographique indexée");

                entity.Property(e => e.ZiSection)
                    .HasColumnName("ZI_SECTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("la section associée à la zone géographique indexée");

                entity.Property(e => e.ZiZoneId)
                    .HasColumnName("ZI_ZONE_ID")
                    .HasComment("identifiant de de la zone (parcelle) associée à l'enregistrement");

                entity.HasOne(d => d.ZiNatureCodeNavigation)
                    .WithMany(p => p.TCZoneInfos)
                    .HasForeignKey(d => d.ZiNatureCode)
                    .HasConstraintName("FK_T_C_ZONE_INFOS_T_C_NatureOccupation");

                entity.HasOne(d => d.ZiZone)
                    .WithMany(p => p.TCZoneInfos)
                    .HasForeignKey(d => d.ZiZoneId)
                    .HasConstraintName("FK_T_C_ZONE_INFOS_T_ZONE");
            });

            modelBuilder.Entity<TCarte>(entity =>
            {
                entity.HasKey(e => e.CarteId);

                entity.ToTable("T_CARTE");

                entity.Property(e => e.CarteId)
                    .HasColumnName("CARTE_ID")
                    .HasComment("identifiant d'une carte");

                entity.Property(e => e.CarteBActive)
                    .IsRequired()
                    .HasColumnName("CARTE_bACTIVE")
                    .HasDefaultValueSql("((1))")
                    .HasComment("vrai indique que la carte est active");

                entity.Property(e => e.CarteBPublique)
                    .HasColumnName("CARTE_bPublique")
                    .HasComment("Vrai indique que la carte est publique");

                entity.Property(e => e.CarteDescription)
                    .HasColumnName("CARTE_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description d'une carte");

                entity.Property(e => e.CarteLibelle)
                    .HasColumnName("CARTE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé d'une carte");

                entity.Property(e => e.CarteUrl)
                    .HasColumnName("CARTE_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("URL de la DYNAMICMAPSERVICE");

                entity.Property(e => e.IdComVille).HasColumnName("ID_COM_VILLE");
            });

            modelBuilder.Entity<TCategorie>(entity =>
            {
                entity.HasKey(e => e.CatCode);

                entity.ToTable("T_Categorie");

                entity.Property(e => e.CatCode)
                    .HasColumnName("CAT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Identifiant de la catégorie");

                entity.Property(e => e.CatDescription)
                    .HasColumnName("CAT_DESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Description de la catégorie");

                entity.Property(e => e.CatLibelle)
                    .HasColumnName("CAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libellé de la catégorie");
            });

            modelBuilder.Entity<TCategorieIndicateur>(entity =>
            {
                entity.ToTable("T_Categorie_Indicateur");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasComment("identifiant de la relation CATEGORIE et INDICATEUR");

                entity.Property(e => e.CatCode)
                    .HasColumnName("CAT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Identifiant de la catégorie associée");

                entity.Property(e => e.IndCode)
                    .HasColumnName("IND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Identifiant de l'indicateur associé");

                entity.HasOne(d => d.CatCodeNavigation)
                    .WithMany(p => p.TCategorieIndicateur)
                    .HasForeignKey(d => d.CatCode)
                    .HasConstraintName("FK_T_Categorie_Indicateur_T_Categorie");

                entity.HasOne(d => d.IndCodeNavigation)
                    .WithMany(p => p.TCategorieIndicateur)
                    .HasForeignKey(d => d.IndCode)
                    .HasConstraintName("FK_T_Categorie_Indicateur_T_Indicateur");
            });

            modelBuilder.Entity<TComVille>(entity =>
            {
                entity.ToTable("T_COM_VILLE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDelete).HasColumnName("Is_delete");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TComVilleQuartier>(entity =>
            {
                entity.ToTable("T_COM_VILLE_QUARTIER");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdComVille).HasColumnName("ID_COM_VILLE");

                entity.Property(e => e.LibQuartier)
                    .HasColumnName("LIB_QUARTIER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TConfiguration>(entity =>
            {
                entity.HasKey(e => e.ConfId);

                entity.ToTable("T_CONFIGURATION");

                entity.Property(e => e.ConfId)
                    .HasColumnName("CONF_ID")
                    .HasComment("identifiant de l'enregistrement");

                entity.Property(e => e.CofDevise)
                    .IsRequired()
                    .HasColumnName("COF_DEVISE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('  F CFA')")
                    .HasComment("la dévise monétaire exploitée");

                entity.Property(e => e.ConfAutre1)
                    .HasColumnName("CONF_AUTRE_1")
                    .IsUnicode(false);

                entity.Property(e => e.ConfAutre2)
                    .HasColumnName("CONF_AUTRE_2")
                    .IsUnicode(false);

                entity.Property(e => e.ConfAutre3)
                    .HasColumnName("CONF_AUTRE_3")
                    .IsUnicode(false);

                entity.Property(e => e.ConfAutre4)
                    .HasColumnName("CONF_AUTRE_4")
                    .IsUnicode(false);

                entity.Property(e => e.ConfAutre5)
                    .HasColumnName("CONF_AUTRE_5")
                    .IsUnicode(false);

                entity.Property(e => e.ConfChaineConnexion)
                    .HasColumnName("CONF_CHAINE_CONNEXION")
                    .IsUnicode(false);

                entity.Property(e => e.ConfCommune)
                    .IsRequired()
                    .HasColumnName("CONF_COMMUNE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("nom de la commune");

                entity.Property(e => e.ConfCommuneCode)
                    .IsRequired()
                    .HasColumnName("CONF_COMMUNE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code de la commune");

                entity.Property(e => e.ConfDateDebutFacturationATraiter)
                    .HasColumnName("CONF_DATE_DEBUT_FACTURATION_A_TRAITER")
                    .HasColumnType("date")
                    .HasComment("date à partir de laquelle on doit traiter (évaluer) les facturations en attente. Les facturation des dates précédentes ne sont pas évaluées");

                entity.Property(e => e.ConfDecoupageCadastre)
                    .HasColumnName("CONF_DECOUPAGE_CADASTRE")
                    .HasComment("identifiant de la ligne de T_ZONE_TYPE concernant le découpage cadastral de la commune");

                entity.Property(e => e.ConfDecoupageCommune)
                    .HasColumnName("CONF_DECOUPAGE_COMMUNE")
                    .HasComment("identifiant de la ligne de T_ZONE_TYPE concernant le découpage administratif de la commune");

                entity.Property(e => e.ConfEtatDash1)
                    .HasColumnName("CONF_ETAT_DASH_1")
                    .IsUnicode(false);

                entity.Property(e => e.ConfEtatDash2)
                    .HasColumnName("CONF_ETAT_DASH_2")
                    .IsUnicode(false);

                entity.Property(e => e.ConfEtatFacture)
                    .HasColumnName("CONF_ETAT_FACTURE")
                    .IsUnicode(false);

                entity.Property(e => e.ConfImageFond)
                    .HasColumnName("CONF_IMAGE_FOND")
                    .HasColumnType("image")
                    .HasComment("Image de fond");

                entity.Property(e => e.ConfMontantTp)
                    .HasColumnName("CONF_MONTANT_TP")
                    .HasComment("montant à partir du quel on considère que le projet est d'intérêt public. (Travaux Public)");

                entity.Property(e => e.ConfTitreDiapoAcceuil)
                    .HasColumnName("CONF_TITRE_DIAPO_ACCEUIL")
                    .IsUnicode(false)
                    .HasComment("Texte entête de la diapositive présente sur l'écran d'acceuil");

                entity.Property(e => e.ConfUrlImage)
                    .HasColumnName("CONF_URL_IMAGE")
                    .IsUnicode(false);

                entity.Property(e => e.ConfZoneCategorieCommune)
                    .HasColumnName("CONF_ZONE_CATEGORIE_COMMUNE")
                    .HasComment("identifiant de la catégorie représentant le découpage communal dans T_ZONE_CATEGORIE");

                entity.Property(e => e.ConfZoneCategorieIlot)
                    .HasColumnName("CONF_ZONE_CATEGORIE_ILOT")
                    .HasComment("identifiant de la catégorie représentant le découpage par ilot dans T_ZONE_CATEGORIE");

                entity.Property(e => e.ConfZoneCategorieLot)
                    .HasColumnName("CONF_ZONE_CATEGORIE_LOT")
                    .HasComment("identifiant de la catégorie représentant le découpage par lot dans T_ZONE_CATEGORIE");

                entity.Property(e => e.ConfZoneCategorieQuartier)
                    .HasColumnName("CONF_ZONE_CATEGORIE_QUARTIER")
                    .HasComment("identifiant de la catégorie représentant le découpage par quartier dans T_ZONE_CATEGORIE");

                entity.Property(e => e.Wkid)
                    .HasColumnName("WKID")
                    .IsUnicode(false);

                entity.HasOne(d => d.ConfDecoupageCadastreNavigation)
                    .WithMany(p => p.TConfigurationConfDecoupageCadastreNavigation)
                    .HasForeignKey(d => d.ConfDecoupageCadastre)
                    .HasConstraintName("FK_T_CONFIGURATION_T_ZONE_TYPE_CADASTRAL");

                entity.HasOne(d => d.ConfDecoupageCommuneNavigation)
                    .WithMany(p => p.TConfigurationConfDecoupageCommuneNavigation)
                    .HasForeignKey(d => d.ConfDecoupageCommune)
                    .HasConstraintName("FK_T_CONFIGURATION_T_ZONE_TYPE_COMMUNAL");
            });

            modelBuilder.Entity<TConfigurationDashboard>(entity =>
            {
                entity.HasKey(e => e.ConfdashId);

                entity.ToTable("T_CONFIGURATION_DASHBOARD");

                entity.Property(e => e.ConfdashId)
                    .HasColumnName("CONFDASH_ID")
                    .HasComment("identifiant d'une configuration du module DASHBOARD");

                entity.Property(e => e.ConfdashIaBas1)
                    .HasColumnName("CONFDASH_IA_BAS_1")
                    .HasComment("ensemble d'information associé au premier element de la deuxième ligne dans DASHBOARD");

                entity.Property(e => e.ConfdashIaBas2)
                    .HasColumnName("CONFDASH_IA_BAS_2")
                    .HasComment("ensemble d'information associé au deuxième element de la deuxième ligne dans DASHBOARD");

                entity.Property(e => e.ConfdashIaBas3)
                    .HasColumnName("CONFDASH_IA_BAS_3")
                    .HasComment("ensemble d'information associé au troisième element de la deuxième ligne dans DASHBOARD");

                entity.Property(e => e.ConfdashIaHaut1)
                    .HasColumnName("CONFDASH_IA_HAUT_1")
                    .HasComment("ensemble d'information associé au premier element de la première ligne dans DASHBOARD");

                entity.Property(e => e.ConfdashIaHaut2)
                    .HasColumnName("CONFDASH_IA_HAUT_2")
                    .HasComment("ensemble d'information associé au second element de la première ligne dans DASHBOARD");

                entity.Property(e => e.ConfdashIaHaut3)
                    .HasColumnName("CONFDASH_IA_HAUT_3")
                    .HasComment("ensemble d'information associé au troisième element de la première ligne dans DASHBOARD");
            });

            modelBuilder.Entity<TConfigurationSecurite>(entity =>
            {
                entity.HasKey(e => e.ConfsecId);

                entity.ToTable("T_CONFIGURATION_SECURITE");

                entity.Property(e => e.ConfsecId)
                    .HasColumnName("CONFSEC_ID")
                    .HasComment("identifiant d'une configuration pour la SECURITE->SUIVI");

                entity.Property(e => e.ConfsecCatCode)
                    .HasColumnName("CONFSEC_CAT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant de la catégorie sécurité exploitée dans le module Sécurité");

                entity.Property(e => e.ConfsecIaBasDroit)
                    .HasColumnName("CONFSEC_IA_BAS_DROIT")
                    .HasComment("ensemble d'information à représenter dans l'angle bas droit");

                entity.Property(e => e.ConfsecIaHautDroit)
                    .HasColumnName("CONFSEC_IA_HAUT_DROIT")
                    .HasComment("ensemble d'information à représenter dans l'angle haut droit");

                entity.HasOne(d => d.ConfsecIaBasDroitNavigation)
                    .WithMany(p => p.TConfigurationSecuriteConfsecIaBasDroitNavigation)
                    .HasForeignKey(d => d.ConfsecIaBasDroit)
                    .HasConstraintName("FK_T_CONFIGURATION_SECURITE_T_IA_INDICATEUR1");

                entity.HasOne(d => d.ConfsecIaHautDroitNavigation)
                    .WithMany(p => p.TConfigurationSecuriteConfsecIaHautDroitNavigation)
                    .HasForeignKey(d => d.ConfsecIaHautDroit)
                    .HasConstraintName("FK_T_CONFIGURATION_SECURITE_T_IA_INDICATEUR");
            });

            modelBuilder.Entity<TDashboardRecettePaiement>(entity =>
            {
                entity.HasKey(e => e.DashRecetteId);

                entity.ToTable("T_DASHBOARD_RECETTE_PAIEMENT");

                entity.Property(e => e.DashRecetteId)
                    .HasColumnName("DASH_RECETTE_ID")
                    .HasComment("identifiant de l'enregistrement");

                entity.Property(e => e.DashRecetteCommuneId)
                    .HasColumnName("DASH_RECETTE_COMMUNE_ID")
                    .HasComment("id de la zone définissant la commune concernée par l'enregistrement");

                entity.Property(e => e.DashRecetteDate)
                    .HasColumnName("DASH_RECETTE_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date concernée par la recette");

                entity.Property(e => e.DashRecetteIlotId)
                    .HasColumnName("DASH_RECETTE_ILOT_ID")
                    .HasComment("id de la zone définissant l'ilot concerné par l'enregistrement");

                entity.Property(e => e.DashRecetteLotId)
                    .HasColumnName("DASH_RECETTE_LOT_ID")
                    .HasComment("id de la zone définissant le lot concerné par l'enregistrement");

                entity.Property(e => e.DashRecettePrevision)
                    .HasColumnName("DASH_RECETTE_PREVISION")
                    .HasComment("recette prévisionnelle théorique à cette date");

                entity.Property(e => e.DashRecetteQuartierId)
                    .HasColumnName("DASH_RECETTE_QUARTIER_ID")
                    .HasComment("id de la zone définissant e quartier concerné par l'enregistrement");

                entity.Property(e => e.DashRecetteRecette)
                    .HasColumnName("DASH_RECETTE_RECETTE")
                    .HasComment("recette effectivement récoltée à cette date");

                entity.Property(e => e.DashRecetteRetard)
                    .HasColumnName("DASH_RECETTE_RETARD")
                    .HasComment("retard de recette (décallage entre prévision et recette effective)");

                entity.Property(e => e.DashRecetteZoneId)
                    .HasColumnName("DASH_RECETTE_ZONE_ID")
                    .HasComment("identifiant de la zone concernée");

                entity.HasOne(d => d.DashRecetteZone)
                    .WithMany(p => p.TDashboardRecettePaiement)
                    .HasForeignKey(d => d.DashRecetteZoneId)
                    .HasConstraintName("FK_T_DASHBOARD_RECETTE_PAIEMENT_T_ZONE");
            });

            modelBuilder.Entity<TDroit>(entity =>
            {
                entity.HasKey(e => e.DroId);

                entity.ToTable("T_Droit");

                entity.Property(e => e.DroId)
                    .HasColumnName("DRO_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DroDescription)
                    .HasColumnName("DRO_Description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DroLibelle)
                    .IsRequired()
                    .HasColumnName("DRO_Libelle")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TECandidat>(entity =>
            {
                entity.HasKey(e => e.CandId)
                    .HasName("PK_T_Candidat");

                entity.ToTable("T_E_Candidat");

                entity.Property(e => e.CandId)
                    .HasColumnName("CAND_ID")
                    .HasComment("Identifiant du Candidat il est auto incremente");

                entity.Property(e => e.CandDateNais)
                    .HasColumnName("CAND_DATE_NAIS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("La date de naissance du candidat");

                entity.Property(e => e.CandMat)
                    .HasColumnName("CAND_MAT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Matricule du candidat");

                entity.Property(e => e.CandNom)
                    .HasColumnName("CAND_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nom du candidat");

                entity.Property(e => e.CandPrenom)
                    .HasColumnName("CAND_PRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Prenom du candidat");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("La description");

                entity.Property(e => e.EchId)
                    .HasColumnName("ECH_ID")
                    .HasComment("L'identifiant de l'echeance electoral auquel le candidat participe");

                entity.Property(e => e.PartId)
                    .HasColumnName("PART_ID")
                    .HasComment("L'indentifiant du parti politique auquel le candidat appartien");

                entity.HasOne(d => d.Ech)
                    .WithMany(p => p.TECandidat)
                    .HasForeignKey(d => d.EchId)
                    .HasConstraintName("FK_T_E_Candidat_T_E_Echeance_Electoral");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.TECandidat)
                    .HasForeignKey(d => d.PartId)
                    .HasConstraintName("FK_T_E_Candidat_T_E_Regroupement_Politique");
            });

            modelBuilder.Entity<TECentreElectoral>(entity =>
            {
                entity.HasKey(e => e.CentId)
                    .HasName("PK_T_Centre_Electoral");

                entity.ToTable("T_E_Centre_Electoral");

                entity.Property(e => e.CentId)
                    .HasColumnName("CENT_ID")
                    .HasComment("L'identifiant du centre electoral");

                entity.Property(e => e.CentLibelle)
                    .HasColumnName("CENT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nom du centre electoral");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("breve description du centre electoral");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZONE_ID")
                    .HasComment("L'identifiant de la zone geographique");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.TECentreElectoral)
                    .HasForeignKey(d => d.ZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Centre_Electoral_T_ZONE");
            });

            modelBuilder.Entity<TEEcheanceElectoral>(entity =>
            {
                entity.HasKey(e => e.EchId);

                entity.ToTable("T_E_Echeance_Electoral");

                entity.Property(e => e.EchId)
                    .HasColumnName("ECH_ID")
                    .HasComment("Identifiant de l'echeance electorale");

                entity.Property(e => e.EchDate)
                    .HasColumnName("ECH_DATE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Date de l'echeance electorale");

                entity.Property(e => e.EchLibelle)
                    .HasColumnName("ECH_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("le libelle ou la designation de lecheance electorale");
            });

            modelBuilder.Entity<TEIncident>(entity =>
            {
                entity.HasKey(e => e.IncId);

                entity.ToTable("T_E_Incident");

                entity.Property(e => e.IncId).HasColumnName("INC_ID");

                entity.Property(e => e.IncCentId)
                    .HasColumnName("INC_CENT_ID")
                    .HasComment("Identifiant du centre dans lequel l'incident s'est produit");

                entity.Property(e => e.IncDate)
                    .HasColumnName("INC_DATE")
                    .HasColumnType("datetime")
                    .HasComment("Date à laquelle l'incident a eu lieu");

                entity.Property(e => e.IncDescription)
                    .HasColumnName("INC_DESCRIPTION")
                    .HasComment("description relative à l'incident");

                entity.Property(e => e.IncEchId)
                    .HasColumnName("INC_ECH_ID")
                    .HasComment("Identifiant de l'échéance a laquelle l'incident s'est produit");

                entity.Property(e => e.IncLibelle)
                    .HasColumnName("INC_LIBELLE")
                    .HasComment("Libelle de l'incident");

                entity.HasOne(d => d.IncCent)
                    .WithMany(p => p.TEIncident)
                    .HasForeignKey(d => d.IncCentId)
                    .HasConstraintName("FK_T_E_Incident_T_E_Centre_Electoral");

                entity.HasOne(d => d.IncEch)
                    .WithMany(p => p.TEIncident)
                    .HasForeignKey(d => d.IncEchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_E_Incident_T_E_Echeance_Electoral");
            });

            modelBuilder.Entity<TERegroupementPolitique>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK_T_Regroupement_Politique");

                entity.ToTable("T_E_Regroupement_Politique");

                entity.Property(e => e.PartId)
                    .HasColumnName("PART_ID")
                    .HasComment("Identifiant du Regroupement Politique");

                entity.Property(e => e.PartAdrPost)
                    .HasColumnName("PART_ADR_POST")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Adresse postale du parti politique");

                entity.Property(e => e.PartEmbleme)
                    .HasColumnName("PART_EMBLEME")
                    .HasColumnType("image")
                    .HasComment("Embleme du parti politique");

                entity.Property(e => e.PartLibelle)
                    .HasColumnName("PART_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libelle du parti politique");

                entity.Property(e => e.PartSigle)
                    .HasColumnName("PART_SIGLE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("Sigle du parti politique");
            });

            modelBuilder.Entity<TErreur>(entity =>
            {
                entity.HasKey(e => e.ErrId);

                entity.ToTable("T_Erreur");

                entity.Property(e => e.ErrId)
                    .HasColumnName("ERR_ID")
                    .HasComment("Identifiant de la ligne d'erreur")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de l'utilisateur ayant effectué l'action à l'origine de la génération d'erreur");

                entity.Property(e => e.ErrMessage)
                    .IsRequired()
                    .HasColumnName("ERR_Message")
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("le message associé à l'erreur");

                entity.Property(e => e.ErrMethode)
                    .IsRequired()
                    .HasColumnName("ERR_Methode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("le nom de la méthode au sein de laquelle l'erreur s'est produite");

                entity.Property(e => e.ErrObjet)
                    .IsRequired()
                    .HasColumnName("ERR_Objet")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("Le nom de la classe au sein de laquelle l'erreur s'est produite");

                entity.Property(e => e.ErrPileAppel)
                    .IsRequired()
                    .HasColumnName("ERR_PileAppel")
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("l'ensemble des appels systèmes ayant précédent l'erreur");

                entity.Property(e => e.ErrProjet)
                    .IsRequired()
                    .HasColumnName("ERR_Projet")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("le nom du projet au sein duquel l'erreur s'est produite");

                entity.HasOne(d => d.Err)
                    .WithOne(p => p.TErreur)
                    .HasForeignKey<TErreur>(d => d.ErrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_Erreur_T_Agent");
            });

            modelBuilder.Entity<TEspaceType>(entity =>
            {
                entity.HasKey(e => e.EsptypId)
                    .HasName("PK_T_ESPACEMARCHE_TYPE");

                entity.ToTable("T_ESPACE_TYPE");

                entity.Property(e => e.EsptypId)
                    .HasColumnName("ESPTYP_ID")
                    .HasComment("identifiant du type d'espace")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsptypDescription)
                    .HasColumnName("ESPTYP_DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("description du type d'espace");

                entity.Property(e => e.EsptypLibelle)
                    .HasColumnName("ESPTYP_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du type d'espace (TABLE, MAGASIN, ....)");
            });

            modelBuilder.Entity<TEspacemarche>(entity =>
            {
                entity.HasKey(e => e.EspmarchId);

                entity.ToTable("T_ESPACEMARCHE");

                entity.Property(e => e.EspmarchId)
                    .HasColumnName("ESPMARCH_ID")
                    .HasComment("identifiant de l'espace marché");

                entity.Property(e => e.EspmarchEsptypId)
                    .HasColumnName("ESPMARCH_ESPTYP_ID")
                    .HasComment("identifiant du type d'espace (id de table, magasin, etale, ...)");

                entity.Property(e => e.EspmarchLibelle)
                    .HasColumnName("ESPMARCH_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé éventuellement associé à l'espace");

                entity.Property(e => e.EspmarchMarchId)
                    .HasColumnName("ESPMARCH_MARCH_ID")
                    .HasComment("identifiant du marché abritant l'espace");

                entity.Property(e => e.EspmarchNiveau)
                    .HasColumnName("ESPMARCH_NIVEAU")
                    .HasComment("niveau où se situe l'espace");

                entity.Property(e => e.EspmarchNummairie)
                    .HasColumnName("ESPMARCH_NUMMAIRIE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("numéro de mairie associé à l'espace");

                entity.Property(e => e.EspmarchRangee)
                    .HasColumnName("ESPMARCH_RANGEE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("rangée où se situe l'espace");

                entity.Property(e => e.EspmarchZiId)
                    .HasColumnName("ESPMARCH_ZI_ID")
                    .HasComment("identifiant de la zone abritant l'espace");

                entity.HasOne(d => d.EspmarchEsptyp)
                    .WithMany(p => p.TEspacemarche)
                    .HasForeignKey(d => d.EspmarchEsptypId)
                    .HasConstraintName("FK_T_ESPACEMARCHE_T_ESPACE_TYPE");

                entity.HasOne(d => d.EspmarchMarch)
                    .WithMany(p => p.TEspacemarche)
                    .HasForeignKey(d => d.EspmarchMarchId)
                    .HasConstraintName("FK_T_ESPACEMARCHE_T_MARCHE");

                entity.HasOne(d => d.EspmarchZi)
                    .WithMany(p => p.TEspacemarche)
                    .HasForeignKey(d => d.EspmarchZiId)
                    .HasConstraintName("FK_T_ESPACEMARCHE_T_C_ZONE_INFOS");
            });

            modelBuilder.Entity<TFacturePeriodiqueTemp>(entity =>
            {
                entity.HasKey(e => e.FacperId);

                entity.ToTable("T_FACTURE_PERIODIQUE_TEMP");

                entity.Property(e => e.FacperId)
                    .HasColumnName("FACPER_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.FacperBExploite)
                    .HasColumnName("FACPER_bExploite")
                    .HasDefaultValueSql("((0))")
                    .HasComment("VRAI indique que la ligne courante est déjà passée à la facturation ");

                entity.Property(e => e.FacperDebut)
                    .HasColumnName("FACPER_DEBUT")
                    .HasColumnType("datetime")
                    .HasComment("début de la période de facturation");

                entity.Property(e => e.FacperFin)
                    .HasColumnName("FACPER_FIN")
                    .HasColumnType("datetime")
                    .HasComment("fin de la période de facturation");

                entity.Property(e => e.FacperTaxactId)
                    .HasColumnName("FACPER_TAXACT_ID")
                    .HasComment("identifiant de la taxe activité");

                entity.Property(e => e.FacperValeur)
                    .HasColumnName("FACPER_VALEUR")
                    .HasComment("valeur de la facturation");

                entity.HasOne(d => d.FacperTaxact)
                    .WithMany(p => p.TFacturePeriodiqueTemp)
                    .HasForeignKey(d => d.FacperTaxactId)
                    .HasConstraintName("FK_T_FACTURE_PERIODIQUE_TEMP_T_RES_TAXEACTIVITE");
            });

            modelBuilder.Entity<TGeneratorId>(entity =>
            {
                entity.HasKey(e => e.GenId);

                entity.ToTable("T_GENERATOR_ID");

                entity.Property(e => e.GenId)
                    .HasColumnName("GEN_ID")
                    .HasComment("identifiant généré");

                entity.Property(e => e.GenDescription)
                    .HasColumnName("GEN_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("motif indiquant la raison de la génération d'un identifiant");
            });

            modelBuilder.Entity<TIaIndicateur>(entity =>
            {
                entity.HasKey(e => e.IaId);

                entity.ToTable("T_IA_INDICATEUR");

                entity.Property(e => e.IaId)
                    .HasColumnName("IA_ID")
                    .HasComment("les indicateurs sont représentés dans un bloc d'information affichant un indicateur principal et un ensemble d'indicateur associé. Cette propriété représente l'identifiant du bloc d'informtion indexé");

                entity.Property(e => e.IaIndCode)
                    .HasColumnName("IA_IND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant de l'indicateur principal associé");

                entity.Property(e => e.IaLibelle)
                    .HasColumnName("IA_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("libellé du bloc d'information");

                entity.Property(e => e.IaNbMois)
                    .HasColumnName("IA_NB_MOIS")
                    .HasComment("0 indique que l'information est à ignorer, mais un nombre positif indique le nombre de mois à considérer en arrière à partir de la date système");
            });

            modelBuilder.Entity<TIaIndicateurAssocie>(entity =>
            {
                entity.HasKey(e => e.IaIndId);

                entity.ToTable("T_IA_INDICATEUR_ASSOCIE");

                entity.Property(e => e.IaIndId)
                    .HasColumnName("IA_IND_ID")
                    .HasComment("identifiant d'un indicateur complémentaire à un indicateur associé principal");

                entity.Property(e => e.IaIndIaId)
                    .HasColumnName("IA_IND_IA_ID")
                    .HasComment("identifiant d'un indicateur associé");

                entity.Property(e => e.IaIndIndCode)
                    .HasColumnName("IA_IND_IND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant d'un indicateur");

                entity.HasOne(d => d.IaIndIa)
                    .WithMany(p => p.TIaIndicateurAssocie)
                    .HasForeignKey(d => d.IaIndIaId)
                    .HasConstraintName("FK_T_IA_INDICATEUR_ASSOCIE_T_IA_INDICATEUR");

                entity.HasOne(d => d.IaIndIndCodeNavigation)
                    .WithMany(p => p.TIaIndicateurAssocie)
                    .HasForeignKey(d => d.IaIndIndCode)
                    .HasConstraintName("FK_T_IA_INDICATEUR_ASSOCIE_T_Indicateur");
            });

            modelBuilder.Entity<TImageDiapo>(entity =>
            {
                entity.HasKey(e => e.ImgId);

                entity.ToTable("T_IMAGE_DIAPO");

                entity.Property(e => e.ImgId)
                    .HasColumnName("IMG_ID")
                    .HasComment("identifiant de l'image");

                entity.Property(e => e.ImgBActif)
                    .HasColumnName("IMG_bACTIF")
                    .HasComment("booléen indiquant si l'image courante doit être prise en compte");

                entity.Property(e => e.ImgDescription)
                    .HasColumnName("IMG_DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("texte descriptif de l'image");

                entity.Property(e => e.ImgPicture)
                    .HasColumnName("IMG_PICTURE")
                    .HasColumnType("image")
                    .HasComment("fichier image de la diapositive");

                entity.Property(e => e.ImgTitre)
                    .HasColumnName("IMG_TITRE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("titre de l'image");
            });

            modelBuilder.Entity<TIncident>(entity =>
            {
                entity.HasKey(e => e.IncId);

                entity.ToTable("T_Incident");

                entity.Property(e => e.IncId)
                    .HasColumnName("INC_ID")
                    .HasComment("Identifiant de l'enregistrement");

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de l'agent qui émet l'incident");

                entity.Property(e => e.IncBEstBloquant)
                    .HasColumnName("INC_bEstBloquant")
                    .IsUnicode(false)
                    .HasComment("indique si l'incident empêche l'exploitation de l'application");

                entity.Property(e => e.IncDate)
                    .HasColumnName("INC_Date")
                    .HasColumnType("datetime")
                    .HasComment("date d'émission de l'incident");

                entity.Property(e => e.IncDescription)
                    .HasColumnName("INC_Description")
                    .IsUnicode(false)
                    .HasComment("description de l'incident");

                entity.Property(e => e.ModId)
                    .HasColumnName("MOD_ID")
                    .HasComment("identifiant du module concerné par l'incident");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.TIncident)
                    .HasForeignKey(d => d.AgId)
                    .HasConstraintName("FK_T_Incident_T_Agent");

                entity.HasOne(d => d.Mod)
                    .WithMany(p => p.TIncident)
                    .HasForeignKey(d => d.ModId)
                    .HasConstraintName("FK_T_Incident_T_Module");
            });

            modelBuilder.Entity<TIndicateur>(entity =>
            {
                entity.HasKey(e => e.IndCode)
                    .HasName("PK_T_INDICATEUR");

                entity.ToTable("T_Indicateur");

                entity.Property(e => e.IndCode)
                    .HasColumnName("IND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Identifiant de l'indicateur");

                entity.Property(e => e.IdOperation)
                    .HasColumnName("ID_OPERATION")
                    .HasComment("Identifiant de l'opération dont résulte l'indicateur courant");

                entity.Property(e => e.IndBNumerique)
                    .HasColumnName("IND_bNumerique")
                    .HasComment("indique si l'indicateur a une valeur numérique OU alphanumérique");

                entity.Property(e => e.IndCodeParent)
                    .HasColumnName("IND_CODE_PARENT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Indicateur parent de l'indicateur courant");

                entity.Property(e => e.IndCodeRattache)
                    .HasColumnName("IND_CODE_RATTACHE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant de l'indicateur auquel l'indicateur est éventuellement rattaché");

                entity.Property(e => e.IndDescription)
                    .HasColumnName("IND_DESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("Description de l'indicateur");

                entity.Property(e => e.IndLibelle)
                    .HasColumnName("IND_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libellé de l'indicateur");
            });

            modelBuilder.Entity<TMail>(entity =>
            {
                entity.HasKey(e => e.MailId);

                entity.ToTable("T_Mail");

                entity.Property(e => e.MailId)
                    .HasColumnName("MAIL_ID")
                    .HasComment("identifiant du mail");

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de l'agent émetteur du mail");

                entity.Property(e => e.MailDate)
                    .HasColumnName("MAIL_Date")
                    .HasColumnType("datetime")
                    .HasComment("date d'emission du message");

                entity.Property(e => e.MailMessageEnrichi)
                    .HasColumnName("MAIL_Message_enrichi")
                    .IsUnicode(false)
                    .HasComment("message enrichi avec les complément de mise en page et de formattage de police");

                entity.Property(e => e.MailMessageSimple)
                    .HasColumnName("MAIL_Message_simple")
                    .IsUnicode(false)
                    .HasComment("message brute associé au mail");

                entity.Property(e => e.MailObjet)
                    .HasColumnName("MAIL_Objet")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("objet du mail");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.TMail)
                    .HasForeignKey(d => d.AgId)
                    .HasConstraintName("FK_T_Mail_T_Agent");
            });

            modelBuilder.Entity<TMailAgent>(entity =>
            {
                entity.HasKey(e => e.IdMailAgent);

                entity.ToTable("T_Mail_Agent");

                entity.Property(e => e.IdMailAgent)
                    .HasColumnName("ID_MAIL_AGENT")
                    .HasComment("identifiant de l'enregistrement");

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de l'agent destinataire du mail");

                entity.Property(e => e.MailAgBLecture)
                    .HasColumnName("MAIL_AG_bLecture")
                    .HasComment("Indique si le mail a été lu par le destinataire");

                entity.Property(e => e.MailAgDateLecture)
                    .HasColumnName("MAIL_AG_DateLecture")
                    .HasColumnType("datetime")
                    .HasComment("Date à laquelle le mail a été lu par le destinataire");

                entity.Property(e => e.MailId)
                    .HasColumnName("MAIL_ID")
                    .HasComment("identifiant du mail");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.TMailAgent)
                    .HasForeignKey(d => d.AgId)
                    .HasConstraintName("FK_T_Mail_Agent_T_Agent");

                entity.HasOne(d => d.Mail)
                    .WithMany(p => p.TMailAgent)
                    .HasForeignKey(d => d.MailId)
                    .HasConstraintName("FK_T_Mail_Agent_T_Mail");
            });

            modelBuilder.Entity<TMarche>(entity =>
            {
                entity.HasKey(e => e.MarchId);

                entity.ToTable("T_MARCHE");

                entity.Property(e => e.MarchId)
                    .HasColumnName("MARCH_ID")
                    .HasComment("identifiant du marché");

                entity.Property(e => e.MarchDescription)
                    .HasColumnName("MARCH_DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("description du marché");

                entity.Property(e => e.MarchLibelle)
                    .HasColumnName("MARCH_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du marché");
            });

            modelBuilder.Entity<TModule>(entity =>
            {
                entity.HasKey(e => e.ModId);

                entity.ToTable("T_Module");

                entity.Property(e => e.ModId)
                    .HasColumnName("MOD_ID")
                    .HasComment("Identifiant de la table T_Module")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModDescription)
                    .HasColumnName("MOD_Description")
                    .IsUnicode(false)
                    .HasComment("description associée au module");

                entity.Property(e => e.ModLibelle)
                    .HasColumnName("MOD_Libelle")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Libellé d'un module");
            });

            modelBuilder.Entity<TNationalite>(entity =>
            {
                entity.HasKey(e => e.NatId);

                entity.ToTable("T_NATIONALITE");

                entity.Property(e => e.NatId)
                    .HasColumnName("NAT_ID")
                    .HasComment("id de la table");

                entity.Property(e => e.NatLibelle)
                    .HasColumnName("NAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la nationalité");
            });

            modelBuilder.Entity<TOperateur>(entity =>
            {
                entity.HasKey(e => e.OpeId);

                entity.ToTable("T_Operateur");

                entity.Property(e => e.OpeId)
                    .HasColumnName("OPE_ID")
                    .HasComment("Identifiant de l'opérateur");

                entity.Property(e => e.OpeDescription)
                    .HasColumnName("OPE_DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("Description de l'opérateur (ex: une addition; soustraction; ...)");

                entity.Property(e => e.OpeLibelle)
                    .HasColumnName("OPE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libellé de l'opérateur (ex: +; -; x ; /; ...)");
            });

            modelBuilder.Entity<TOperation>(entity =>
            {
                entity.HasKey(e => e.IdOperation);

                entity.ToTable("T_Operation");

                entity.Property(e => e.IdOperation)
                    .HasColumnName("ID_OPERATION")
                    .HasComment("Identifiant de l'opération");

                entity.Property(e => e.IdOperationDroit)
                    .HasColumnName("ID_OPERATION_DROIT")
                    .HasComment("Identifiant de l'opération à droite de l'opérateur (au cas où une opération est considérée comme un objet intervenant dans l'opération)");

                entity.Property(e => e.IdOperationGauche)
                    .HasColumnName("ID_OPERATION_GAUCHE")
                    .HasComment("Identifiant de l'opération à gauche de l'opérateur (au cas où une opération est considérée comme un objet intervenant dans l'opération)");

                entity.Property(e => e.IndCodeDroit)
                    .HasColumnName("IND_CODE_DROIT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant de l'indicateur à droite de la relation");

                entity.Property(e => e.IndCodeGauche)
                    .HasColumnName("IND_CODE_GAUCHE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("identifiant de l'indicateur à gauche de la relation");

                entity.Property(e => e.OpeId)
                    .HasColumnName("OPE_ID")
                    .HasComment("Identifiant de l'opérateur");

                entity.HasOne(d => d.IndCodeDroitNavigation)
                    .WithMany(p => p.TOperationIndCodeDroitNavigation)
                    .HasForeignKey(d => d.IndCodeDroit)
                    .HasConstraintName("FK_T_Operation_T_Indicateur_DROIT");

                entity.HasOne(d => d.IndCodeGaucheNavigation)
                    .WithMany(p => p.TOperationIndCodeGaucheNavigation)
                    .HasForeignKey(d => d.IndCodeGauche)
                    .HasConstraintName("FK_T_Operation_T_Indicateur_GAUCHE");

                entity.HasOne(d => d.Ope)
                    .WithMany(p => p.TOperation)
                    .HasForeignKey(d => d.OpeId)
                    .HasConstraintName("FK_T_Operation_T_Operateur");
            });

            modelBuilder.Entity<TPAnnee>(entity =>
            {
                entity.HasKey(e => e.AnneeId);

                entity.ToTable("T_P_Annee");

                entity.Property(e => e.AnneeId)
                    .HasColumnName("ANNEE_ID")
                    .HasComment("L'identifiant de l'année");

                entity.Property(e => e.AnneeLib)
                    .HasColumnName("ANNEE_LIB")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("l'annee");
            });

            modelBuilder.Entity<TPAnneeFonds>(entity =>
            {
                entity.HasKey(e => e.IdAnneeFonds);

                entity.ToTable("T_P_ANNEE_FONDS");

                entity.Property(e => e.IdAnneeFonds).HasColumnName("Id_annee_fonds");

                entity.Property(e => e.IdAnnee).HasColumnName("Id_annee");

                entity.Property(e => e.IdProgProjet).HasColumnName("Id_prog_projet");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TPAnnees>(entity =>
            {
                entity.HasKey(e => e.AnneeId);

                entity.ToTable("T_P_Annees");

                entity.Property(e => e.AnneeId)
                    .HasColumnName("ANNEE_ID")
                    .HasComment("L'identifiant de l'année");

                entity.Property(e => e.AnneeLib)
                    .HasColumnName("ANNEE_LIB")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("La date ");
            });

            modelBuilder.Entity<TPBailleur>(entity =>
            {
                entity.HasKey(e => e.BaiId);

                entity.ToTable("T_P_Bailleur");

                entity.Property(e => e.BaiId)
                    .HasColumnName("BAI_ID")
                    .HasComment("Identifiant de chaque bailleur");

                entity.Property(e => e.BaiMail)
                    .HasColumnName("BAI_MAIl")
                    .HasComment("le e-mail du bailleur");

                entity.Property(e => e.BaiNom)
                    .HasColumnName("BAI_Nom")
                    .HasComment("Nom du  Bailleur");

                entity.Property(e => e.BaiSigle)
                    .HasColumnName("BAI_Sigle")
                    .HasMaxLength(50)
                    .HasComment("Sigle du bailleur");

                entity.Property(e => e.BaiSteWeb)
                    .HasColumnName("BAi_SteWeb")
                    .HasComment("Site internet du Bailleur");

                entity.Property(e => e.BaiTel)
                    .HasColumnName("BAI_Tel")
                    .HasComment("Contact du bailleur c est a dire son numero de telephone");

                entity.Property(e => e.BaiType)
                    .HasColumnName("BAI_Type")
                    .HasComment("Type de bailleur s'il s'agit par exemple de l'etat ou d'un organisme");
            });

            modelBuilder.Entity<TPCategorie>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("T_P_Categorie");

                entity.Property(e => e.CatId)
                    .HasColumnName("CAT_ID")
                    .HasComment("identifiant de la catégorie de projet");

                entity.Property(e => e.CatDescription)
                    .HasColumnName("CAT_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("description de la catégorie de projet");

                entity.Property(e => e.CatLibelle)
                    .HasColumnName("CAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la catégorie de projet");
            });

            modelBuilder.Entity<TPDepenses>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.ToTable("T_P_Depenses");

                entity.Property(e => e.DepId)
                    .HasColumnName("DEP_ID")
                    .HasComment("identifiant de la dépense");

                entity.Property(e => e.DepAnterieur)
                    .HasColumnName("DEP_ANTERIEUR")
                    .HasComment("dépense antérieure");

                entity.Property(e => e.DepPosterieur)
                    .HasColumnName("DEP_POSTERIEUR")
                    .HasComment("dépense postérieure");

                entity.Property(e => e.DepProgprojId)
                    .HasColumnName("DEP_PROGPROJ_ID")
                    .HasComment("identifiant du programme projet concerné");

                entity.HasOne(d => d.DepProgproj)
                    .WithMany(p => p.TPDepenses)
                    .HasForeignKey(d => d.DepProgprojId)
                    .HasConstraintName("FK_T_P_Depenses_T_P_R_Programme_Projet");
            });

            modelBuilder.Entity<TPEtapeProjet>(entity =>
            {
                entity.HasKey(e => e.EtapeId);

                entity.ToTable("T_P_Etape_Projet");

                entity.Property(e => e.EtapeId)
                    .HasColumnName("ETAPE_ID")
                    .HasComment("Identifiant des differentes etapes d'un projet");

                entity.Property(e => e.EtapeCout)
                    .HasColumnName("ETAPE_COUT")
                    .HasComment("Le cout  de l'etape d'un projet");

                entity.Property(e => e.EtapeDateDebut)
                    .HasColumnName("ETAPE_DATE_DEBUT")
                    .HasColumnType("date")
                    .HasComment("date de debut  de l'etape d'un projet");

                entity.Property(e => e.EtapeDateFin)
                    .HasColumnName("ETAPE_DATE_FIN")
                    .HasColumnType("date")
                    .HasComment("date de fin de l'etape d'un projet");

                entity.Property(e => e.EtapeDesc)
                    .HasColumnName("ETAPE_DESC")
                    .HasComment("description de l'etape d'un projet");

                entity.Property(e => e.EtapeIntitule)
                    .HasColumnName("ETAPE_INTITULE")
                    .HasComment("Intitulé de l'etape d'un projet");

                entity.Property(e => e.EtapePrestId)
                    .HasColumnName("ETAPE_PREST_ID")
                    .HasComment("L'id du prestataire");

                entity.Property(e => e.EtapeProjId)
                    .HasColumnName("ETAPE_PROJ_ID")
                    .HasComment("L'id du projet");

                entity.HasOne(d => d.EtapePrest)
                    .WithMany(p => p.TPEtapeProjet)
                    .HasForeignKey(d => d.EtapePrestId)
                    .HasConstraintName("FK_T_P_Etape_Projet_T_P_Prestataire");

                entity.HasOne(d => d.EtapeProj)
                    .WithMany(p => p.TPEtapeProjet)
                    .HasForeignKey(d => d.EtapeProjId)
                    .HasConstraintName("FK_T_P_Etape_Projet_T_P_Projet");
            });

            modelBuilder.Entity<TPMaitreOeuvre>(entity =>
            {
                entity.HasKey(e => e.MoeId);

                entity.ToTable("T_P_Maitre_Oeuvre");

                entity.Property(e => e.MoeId)
                    .HasColumnName("MOE_ID")
                    .HasComment("Identifiant du maitre d'oeuvre");

                entity.Property(e => e.MoeContact)
                    .HasColumnName("MOE_CONTACT")
                    .IsUnicode(false)
                    .HasComment("Contact  du maitre d'oeuvre");

                entity.Property(e => e.MoeNom)
                    .HasColumnName("MOE_NOM")
                    .IsUnicode(false)
                    .HasComment("Nom ou raison social du maitre d'oeuvre");
            });

            modelBuilder.Entity<TPMaitreOuvrage>(entity =>
            {
                entity.HasKey(e => e.MouId);

                entity.ToTable("T_P_Maitre_Ouvrage");

                entity.Property(e => e.MouId)
                    .HasColumnName("MOU_ID")
                    .HasComment("Identifiant du maitre d'ouvrage");

                entity.Property(e => e.MouNom)
                    .HasColumnName("MOU_NOM")
                    .HasComment("Nom du maitre d'ouvrage");
            });

            modelBuilder.Entity<TPPhaseProjet>(entity =>
            {
                entity.HasKey(e => e.PhaseId);

                entity.ToTable("T_P_PhaseProjet");

                entity.Property(e => e.PhaseId)
                    .HasColumnName("PHASE_ID")
                    .HasComment("identifiant de la phase du projet (étape importante perceptible du projet)");

                entity.Property(e => e.PhaseCout)
                    .HasColumnName("PHASE_COUT")
                    .HasComment("cout de la phase du projet");

                entity.Property(e => e.PhaseDateDebut)
                    .HasColumnName("PHASE_DATE_DEBUT")
                    .HasColumnType("datetime")
                    .HasComment("date du début de laphase");

                entity.Property(e => e.PhaseDateFin)
                    .HasColumnName("PHASE_DATE_FIN")
                    .HasColumnType("datetime")
                    .HasComment("date de fin de phase");

                entity.Property(e => e.PhaseDesc)
                    .HasColumnName("PHASE_DESC")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("description de la phase");

                entity.Property(e => e.PhaseIntitule)
                    .HasColumnName("PHASE_INTITULE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("intitulé de la phase de projet");

                entity.Property(e => e.PhasePrestId)
                    .HasColumnName("PHASE_PREST_ID")
                    .HasComment("identifiant du prestataire");

                entity.Property(e => e.PhaseProjId)
                    .HasColumnName("PHASE_PROJ_ID")
                    .HasComment("identifiant du projet concerné");

                entity.HasOne(d => d.PhasePrest)
                    .WithMany(p => p.TPPhaseProjet)
                    .HasForeignKey(d => d.PhasePrestId)
                    .HasConstraintName("FK_T_P_PhaseProjet_T_P_Prestataire");

                entity.HasOne(d => d.PhaseProj)
                    .WithMany(p => p.TPPhaseProjet)
                    .HasForeignKey(d => d.PhaseProjId)
                    .HasConstraintName("FK_T_P_PhaseProjet_T_P_Projet");
            });

            modelBuilder.Entity<TPPrestataire>(entity =>
            {
                entity.HasKey(e => e.PrestId);

                entity.ToTable("T_P_Prestataire");

                entity.Property(e => e.PrestId)
                    .HasColumnName("PREST_ID")
                    .HasComment("Identifiant de L'entreprise qui se charge de la prestation ");

                entity.Property(e => e.PrestContact)
                    .HasColumnName("PREST_CONTACT")
                    .HasMaxLength(50)
                    .HasComment("Contact de L'entreprise qui se charge de la prestation ");

                entity.Property(e => e.PrestNom)
                    .HasColumnName("PREST_NOM")
                    .HasComment("Nom de L'entreprise qui se charge de la prestation ");

                entity.Property(e => e.PrestSiege)
                    .HasColumnName("PREST_SIEGE")
                    .HasComment("Siege  de L'entreprise qui se charge de la prestation ");
            });

            modelBuilder.Entity<TPProgrammeTriennal>(entity =>
            {
                entity.HasKey(e => e.ProgId);

                entity.ToTable("T_P_ProgrammeTriennal");

                entity.Property(e => e.ProgId)
                    .HasColumnName("PROG_ID")
                    .HasComment("identifiant du programme triennal");

                entity.Property(e => e.ProgDatedebut)
                    .HasColumnName("PROG_DATEDEBUT")
                    .HasColumnType("date")
                    .HasComment("date de debut relative au programme  triennal");

                entity.Property(e => e.ProgDatefin)
                    .HasColumnName("PROG_DATEFIN")
                    .HasColumnType("date")
                    .HasComment("date fin relatives au programme triennal");

                entity.Property(e => e.ProgDescription)
                    .HasColumnName("PROG_DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("description relative au programme triennal");

                entity.Property(e => e.ProgLibelle)
                    .HasColumnName("PROG_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libellé relatif au programme triennal");
            });

            modelBuilder.Entity<TPProjet>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("T_P_Projet");

                entity.Property(e => e.ProjId)
                    .HasColumnName("PROJ_ID")
                    .HasComment("L'identifiant du projet");

                entity.Property(e => e.ProjBMarche)
                    .HasColumnName("PROJ_bMARCHE")
                    .HasComment("booléen indiquant si le projet concerne un marché");

                entity.Property(e => e.ProjBTp)
                    .HasColumnName("PROJ_bTP")
                    .HasComment("booléen indiquant que le projet concerne un intérêt général (Travaux Publics)");

                entity.Property(e => e.ProjCatId)
                    .HasColumnName("PROJ_CAT_ID")
                    .HasComment("identifiant de la catégorie de projet");

                entity.Property(e => e.ProjCout)
                    .HasColumnName("PROJ_Cout")
                    .HasComment("le coût du projet");

                entity.Property(e => e.ProjDateDebut)
                    .HasColumnName("PROJ_DateDebut")
                    .HasColumnType("date")
                    .HasComment("La date de lancement du projet");

                entity.Property(e => e.ProjDateFin)
                    .HasColumnName("PROJ_DateFin")
                    .HasColumnType("date")
                    .HasComment("la date d'achevement du projet");

                entity.Property(e => e.ProjDescription)
                    .HasColumnName("PROJ_Description")
                    .HasComment("La description du projet");

                entity.Property(e => e.ProjEtatRealisation)
                    .HasColumnName("PROJ_EtatRealisation")
                    .HasComment("indique si l'état du projet 0: projet non encore débuté (futur); 1: projet en cours d'exécution; 2:projet terminé");

                entity.Property(e => e.ProjIndicateur)
                    .HasColumnName("PROJ_Indicateur")
                    .HasComment("definir un indicateur du projet");

                entity.Property(e => e.ProjLibelle)
                    .HasColumnName("PROJ_Libelle")
                    .HasComment("Libelle du projet");

                entity.Property(e => e.ProjMoeId)
                    .HasColumnName("PROJ_MOE_ID")
                    .HasComment("identifiant du maître d'oeuvre du projet");

                entity.Property(e => e.ProjMouId)
                    .HasColumnName("PROJ_MOU_ID")
                    .HasComment("identifiant du maître d'ouvrage du projet");

                entity.Property(e => e.ProjZoneId)
                    .HasColumnName("PROJ_ZONE_ID")
                    .HasComment("identifiant de la zone de réalisation du projet");

                entity.HasOne(d => d.ProjCat)
                    .WithMany(p => p.TPProjet)
                    .HasForeignKey(d => d.ProjCatId)
                    .HasConstraintName("FK_T_P_Projet_T_P_Categorie");

                entity.HasOne(d => d.ProjMoe)
                    .WithMany(p => p.TPProjet)
                    .HasForeignKey(d => d.ProjMoeId)
                    .HasConstraintName("FK_T_P_Projet_T_P_Maitre_Oeuvre");

                entity.HasOne(d => d.ProjMou)
                    .WithMany(p => p.TPProjet)
                    .HasForeignKey(d => d.ProjMouId)
                    .HasConstraintName("FK_T_P_Projet_T_P_Maitre_Ouvrage");
            });

            modelBuilder.Entity<TPRMontant>(entity =>
            {
                entity.HasKey(e => e.MontId)
                    .HasName("PK_T_R_Montant");

                entity.ToTable("T_P_R_Montant");

                entity.Property(e => e.MontId)
                    .HasColumnName("MONT_ID")
                    .HasComment("L'identifiant du Montant(Relation entre la table T_R_BAILLEUR et T_R_BAILLEUR) consideré comme notre clé primaire");

                entity.Property(e => e.MontBaiId)
                    .HasColumnName("MONT_BAI_ID")
                    .HasComment("Identifiant du Bailleur associé");

                entity.Property(e => e.MontProjId)
                    .HasColumnName("MONT_PROJ_ID")
                    .HasComment("Identifiant du projet associé");

                entity.Property(e => e.MontSomme)
                    .HasColumnName("MONT_Somme")
                    .HasComment("Le financierb relatif a un bailleur ");

                entity.HasOne(d => d.MontBai)
                    .WithMany(p => p.TPRMontant)
                    .HasForeignKey(d => d.MontBaiId)
                    .HasConstraintName("FK_T_R_Montant_T_P_Bailleur");

                entity.HasOne(d => d.MontProj)
                    .WithMany(p => p.TPRMontant)
                    .HasForeignKey(d => d.MontProjId)
                    .HasConstraintName("FK_T_P_R_Montant_T_P_Projet");
            });

            modelBuilder.Entity<TPRProgTriennalAnnee>(entity =>
            {
                entity.HasKey(e => e.ProgAnId);

                entity.ToTable("T_P_R_ProgTriennalAnnee");

                entity.Property(e => e.ProgAnId)
                    .HasColumnName("PROG_AN_ID")
                    .HasComment("L'identifiant de la table de relation");

                entity.Property(e => e.ProgAnAnneeId)
                    .HasColumnName("PROG_AN_ANNEE_ID")
                    .HasComment("L'identifiant de la table Annee");

                entity.Property(e => e.ProgAnProgId)
                    .HasColumnName("PROG_AN_PROG_ID")
                    .HasComment("L'identifiant de la table projet triennal");

                entity.HasOne(d => d.ProgAnAnnee)
                    .WithMany(p => p.TPRProgTriennalAnnee)
                    .HasForeignKey(d => d.ProgAnAnneeId)
                    .HasConstraintName("FK_T_P_R_ProgTriennalAnnee_T_P_Annee");

                entity.HasOne(d => d.ProgAnProg)
                    .WithMany(p => p.TPRProgTriennalAnnee)
                    .HasForeignKey(d => d.ProgAnProgId)
                    .HasConstraintName("FK_T_P_R_ProgTriennalAnnee_T_P_ProgrammeTriennal");
            });

            modelBuilder.Entity<TPRProgrammeProjet>(entity =>
            {
                entity.HasKey(e => e.ProgprojId);

                entity.ToTable("T_P_R_Programme_Projet");

                entity.Property(e => e.ProgprojId)
                    .HasColumnName("PROGPROJ_ID")
                    .HasComment("Identifiant de la table de relation  programme projet (ProgremmeProjet)");

                entity.Property(e => e.ProgprojNumordre)
                    .HasColumnName("PROGPROJ_NUMORDRE")
                    .HasComment("Le numero d'ordre ");

                entity.Property(e => e.ProgprojProgId)
                    .HasColumnName("PROGPROJ_PROG_ID")
                    .HasComment("Identifiant du projet triennal");

                entity.Property(e => e.ProgprojProjId)
                    .HasColumnName("PROGPROJ_PROJ_ID")
                    .HasComment("Identifiant de la table T_PROJET");

                entity.HasOne(d => d.ProgprojProg)
                    .WithMany(p => p.TPRProgrammeProjet)
                    .HasForeignKey(d => d.ProgprojProgId)
                    .HasConstraintName("FK_T_P_R_Programme_Projet_T_P_ProgrammeTriennal");

                entity.HasOne(d => d.ProgprojProj)
                    .WithMany(p => p.TPRProgrammeProjet)
                    .HasForeignKey(d => d.ProgprojProjId)
                    .HasConstraintName("FK_T_P_R_Programme_Projet_T_P_R_Programme_Projet");
            });

            modelBuilder.Entity<TPRProgrammeProjetAnnee>(entity =>
            {
                entity.HasKey(e => e.ProgProjAnId);

                entity.ToTable("T_P_R_ProgrammeProjet_Annee");

                entity.Property(e => e.ProgProjAnId)
                    .HasColumnName("PROG_PROJ_AN_ID")
                    .HasComment("L'identifiant de la table de relation entre programme_projet et Année");

                entity.Property(e => e.ProgProjAnAnneeId)
                    .HasColumnName("PROG_PROJ_AN_ANNEE_ID")
                    .HasComment("L'identifiant de la table Annee");

                entity.Property(e => e.ProgProjAnDepenseant).HasColumnName("PROG_PROJ_AN_DEPENSEANT");

                entity.Property(e => e.ProgProjAnDepensepost).HasColumnName("PROG_PROJ_AN_DEPENSEPOST");

                entity.Property(e => e.ProgProjAnMontant).HasColumnName("PROG_PROJ_AN_MONTANT");

                entity.Property(e => e.ProgProjAnProgprojId)
                    .HasColumnName("PROG_PROJ_AN_PROGPROJ_ID")
                    .HasComment("L'identifiant de la table Programme_Projet");

                entity.HasOne(d => d.ProgProjAnAnnee)
                    .WithMany(p => p.TPRProgrammeProjetAnnee)
                    .HasForeignKey(d => d.ProgProjAnAnneeId)
                    .HasConstraintName("FK_T_P_R_ProgrammeProjet_Annee_T_P_Annee");

                entity.HasOne(d => d.ProgProjAnProgproj)
                    .WithMany(p => p.TPRProgrammeProjetAnnee)
                    .HasForeignKey(d => d.ProgProjAnProgprojId)
                    .HasConstraintName("FK_T_P_R_ProgrammeProjet_Annee_T_P_R_Programme_Projet1");
            });

            modelBuilder.Entity<TPRProjetZone>(entity =>
            {
                entity.HasKey(e => e.ProzoneId)
                    .HasName("PK_T_R_ProjetZone");

                entity.ToTable("T_P_R_ProjetZone");

                entity.Property(e => e.ProzoneId)
                    .HasColumnName("PROZONE_ID")
                    .HasComment("Identifiant de la relation entre T_P_PROJET et T_ZONE");

                entity.Property(e => e.ProzoneProjId)
                    .HasColumnName("PROZONE_PROJ_ID")
                    .HasComment("Identifiant du projet associé");

                entity.Property(e => e.ProzoneZoneId)
                    .HasColumnName("PROZONE_ZONE_ID")
                    .HasComment("Identifiant de la zone associé");

                entity.HasOne(d => d.ProzoneZone)
                    .WithMany(p => p.TPRProjetZone)
                    .HasForeignKey(d => d.ProzoneZoneId)
                    .HasConstraintName("FK_T_R_ProjetZone_T_ZONE");
            });

            modelBuilder.Entity<TPTache>(entity =>
            {
                entity.HasKey(e => e.TacheId);

                entity.ToTable("T_P_Tache");

                entity.Property(e => e.TacheId)
                    .HasColumnName("TACHE_ID")
                    .HasComment("identifiant de la tâche");

                entity.Property(e => e.TacheDesc)
                    .HasColumnName("TACHE_DESC")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("description de la tâche");

                entity.Property(e => e.TacheEtat)
                    .HasColumnName("TACHE_ETAT")
                    .HasComment("état de réalisation de la tâche (prévision, en cours, terminée)");

                entity.Property(e => e.TacheLibelle)
                    .HasColumnName("TACHE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la tâche");

                entity.Property(e => e.TachePhaseId)
                    .HasColumnName("TACHE_PHASE_ID")
                    .HasComment("identifiant de la phase à laquelle est rattachée la tâche");

                entity.HasOne(d => d.TachePhase)
                    .WithMany(p => p.TPTache)
                    .HasForeignKey(d => d.TachePhaseId)
                    .HasConstraintName("FK_T_P_Tache_T_P_PhaseProjet");
            });

            modelBuilder.Entity<TPTacheRealiser>(entity =>
            {
                entity.HasKey(e => e.TacheRealId);

                entity.ToTable("T_P_TacheRealiser");

                entity.Property(e => e.TacheRealId)
                    .HasColumnName("TACHE_REAL_ID")
                    .HasComment("identifiant de la tâche réalisée");

                entity.Property(e => e.TacheRealAppreciation)
                    .HasColumnName("TACHE_REAL_APPRECIATION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Appréciation de la réalisation");

                entity.Property(e => e.TacheRealPourcentage)
                    .HasColumnName("TACHE_REAL_POURCENTAGE")
                    .HasComment("pourcentatge de réalisation de la tâche atteind après cette réalisation courante");

                entity.Property(e => e.TacheRealTacheId)
                    .HasColumnName("TACHE_REAL_TACHE_ID")
                    .HasComment("identifiant de la tâche concernée");

                entity.HasOne(d => d.TacheRealTache)
                    .WithMany(p => p.TPTacheRealiser)
                    .HasForeignKey(d => d.TacheRealTacheId)
                    .HasConstraintName("FK_T_P_TacheRealiser_T_P_Tache");
            });

            modelBuilder.Entity<TPotentiel>(entity =>
            {
                entity.HasKey(e => e.PotId);

                entity.ToTable("T_POTENTIEL");

                entity.Property(e => e.PotId).HasColumnName("POT_ID");

                entity.Property(e => e.PotAnnee).HasColumnName("POT_ANNEE");

                entity.Property(e => e.PotPotentiel).HasColumnName("POT_POTENTIEL");

                entity.Property(e => e.PotQuartier)
                    .HasColumnName("POT_QUARTIER")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TProprietaire>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("T_PROPRIETAIRE");

                entity.Property(e => e.ProId)
                    .HasColumnName("PRO_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.ProGenreMasculin)
                    .IsRequired()
                    .HasColumnName("PRO_GENRE_MASCULIN")
                    .HasDefaultValueSql("((1))")
                    .HasComment("genre du propriétaire, VRAI pour Masculin");

                entity.Property(e => e.ProNationId)
                    .HasColumnName("PRO_NATION_ID")
                    .HasComment("identifiant de la nationalité du propriétaire");

                entity.Property(e => e.ProNom)
                    .HasColumnName("PRO_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Nom du propriétaire");

                entity.Property(e => e.ProPieceNatureId)
                    .HasColumnName("PRO_PIECE_NATURE_ID")
                    .HasComment("identifiant de la nature de la pièce utilisée");

                entity.Property(e => e.ProPieceNumero)
                    .HasColumnName("PRO_PIECE_NUMERO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("valeur du numéro de pièce");

                entity.Property(e => e.ProPrenom)
                    .HasColumnName("PRO_PRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Prénoms du propriétaire");

                entity.HasOne(d => d.ProNation)
                    .WithMany(p => p.TProprietaire)
                    .HasForeignKey(d => d.ProNationId)
                    .HasConstraintName("FK_T_PROPRIETAIRE_T_NATIONALITE");

                entity.HasOne(d => d.ProPieceNature)
                    .WithMany(p => p.TProprietaire)
                    .HasForeignKey(d => d.ProPieceNatureId)
                    .HasConstraintName("FK_T_PROPRIETAIRE_T_TYPE_PIECE");
            });

            modelBuilder.Entity<TQuartierParcelle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_QUARTIER_PARCELLE");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TRAgentModuleDroit>(entity =>
            {
                entity.HasKey(e => e.AmdId);

                entity.ToTable("T_R_AgentModuleDroit");

                entity.Property(e => e.AmdId).HasColumnName("AMD_ID");

                entity.Property(e => e.AmdIdagent).HasColumnName("AMD_IDAgent");

                entity.Property(e => e.AmdIddroit).HasColumnName("AMD_IDDroit");

                entity.Property(e => e.AmdIdmodule).HasColumnName("AMD_IDModule");

                entity.HasOne(d => d.AmdIdagentNavigation)
                    .WithMany(p => p.TRAgentModuleDroit)
                    .HasForeignKey(d => d.AmdIdagent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_AgentModuleDroit_T_Agent");

                entity.HasOne(d => d.AmdIddroitNavigation)
                    .WithMany(p => p.TRAgentModuleDroit)
                    .HasForeignKey(d => d.AmdIddroit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_AgentModuleDroit_T_Droit");

                entity.HasOne(d => d.AmdIdmoduleNavigation)
                    .WithMany(p => p.TRAgentModuleDroit)
                    .HasForeignKey(d => d.AmdIdmodule)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_AgentModuleDroit_T_Module");
            });

            modelBuilder.Entity<TRCBatimentContribuable>(entity =>
            {
                entity.HasKey(e => e.AbcId)
                    .HasName("PK_T_R_BatimentContribuable");

                entity.ToTable("T_R_C_BatimentContribuable");

                entity.Property(e => e.AbcId)
                    .HasColumnName("ABC_ID")
                    .HasComment("identifiant de la relation contribuable-batiment")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbcBatId)
                    .HasColumnName("ABC_BAT_ID")
                    .HasComment("identifiant du bâtiment participant à la relation");

                entity.Property(e => e.AbcContId)
                    .HasColumnName("ABC_CONT_ID")
                    .HasComment("identifiant du contribuable participant à la relation");

                entity.Property(e => e.AbcDate)
                    .HasColumnName("ABC_DATE")
                    .HasColumnType("date")
                    .HasComment("date d'acquisition");

                entity.Property(e => e.AbcDateFin)
                    .HasColumnName("ABC_DATE_FIN")
                    .HasColumnType("date")
                    .HasComment("date de fin de contrat");

                entity.HasOne(d => d.AbcBat)
                    .WithMany(p => p.TRCBatimentContribuable)
                    .HasForeignKey(d => d.AbcBatId)
                    .HasConstraintName("FK_T_R_C_BatimentContribuable_T_C_Batiment");

                entity.HasOne(d => d.AbcCont)
                    .WithMany(p => p.TRCBatimentContribuable)
                    .HasForeignKey(d => d.AbcContId)
                    .HasConstraintName("FK_T_R_C_BatimentContribuable_T_C_Contribuable");
            });

            modelBuilder.Entity<TRCZoneInfoProprietaireEntreprise>(entity =>
            {
                entity.HasKey(e => e.ZpeId)
                    .HasName("PK_T_R_ZoneInfo_ProprietaireEntreprise");

                entity.ToTable("T_R_C_ZoneInfo_ProprietaireEntreprise");

                entity.Property(e => e.ZpeId)
                    .HasColumnName("ZPE_ID")
                    .HasComment("identifiant de la relation");

                entity.Property(e => e.ZpeCfCode)
                    .HasColumnName("ZPE_CF_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code de la conservation foncière émettrice du titre foncier matérialisant l'acquisition du terrain");

                entity.Property(e => e.ZpeDate)
                    .HasColumnName("ZPE_DATE")
                    .HasColumnType("date")
                    .HasComment("date d'acquisition de la zone géographique par l'entreprise participant à la relation");

                entity.Property(e => e.ZpePeId)
                    .HasColumnName("ZPE_PE_ID")
                    .HasComment("identifiant de l'entreprise participant à la relation");

                entity.Property(e => e.ZpeTf)
                    .HasColumnName("ZPE_TF")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Titre foncier associé à l'acuisition de la zone géographique");

                entity.Property(e => e.ZpeZiId)
                    .HasColumnName("ZPE_ZI_ID")
                    .HasComment("identifiant de la zone géographique participant à la relation");

                entity.HasOne(d => d.ZpeCfCodeNavigation)
                    .WithMany(p => p.TRCZoneInfoProprietaireEntreprise)
                    .HasForeignKey(d => d.ZpeCfCode)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireEntreprise_T_C_ConservationFonciere");

                entity.HasOne(d => d.ZpePe)
                    .WithMany(p => p.TRCZoneInfoProprietaireEntreprise)
                    .HasForeignKey(d => d.ZpePeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireEntreprise_T_C_ProprietaireEntreprise");

                entity.HasOne(d => d.ZpeZi)
                    .WithMany(p => p.TRCZoneInfoProprietaireEntreprise)
                    .HasForeignKey(d => d.ZpeZiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireEntreprise_T_C_ZONE_INFOS");
            });

            modelBuilder.Entity<TRCZoneInfoProprietaireOrdinaire>(entity =>
            {
                entity.HasKey(e => e.ZpoId)
                    .HasName("PK_Table_1");

                entity.ToTable("T_R_C_ZoneInfo_ProprietaireOrdinaire");

                entity.Property(e => e.ZpoId)
                    .HasColumnName("ZPO_ID")
                    .HasComment("Identifiant de la relation");

                entity.Property(e => e.ZpoCfCode)
                    .HasColumnName("ZPO_CF_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code de la conservation foncière émettrice du titre foncier matérialisant l'acquisition du terrain");

                entity.Property(e => e.ZpoDate)
                    .HasColumnName("ZPO_DATE")
                    .HasColumnType("date")
                    .HasComment("date d'acquisition de la zone géographique par le propriétaire ordinaire");

                entity.Property(e => e.ZpoPoId)
                    .HasColumnName("ZPO_PO_ID")
                    .HasComment("identifiant du propriétaire ordinaire participant à la relation");

                entity.Property(e => e.ZpoTf)
                    .HasColumnName("ZPO_TF")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Titre foncier associé à l'acuisition de la zone géographique");

                entity.Property(e => e.ZpoZiId)
                    .HasColumnName("ZPO_ZI_ID")
                    .HasComment("identifiant de la zone géographique participant à la relation");

                entity.HasOne(d => d.ZpoCfCodeNavigation)
                    .WithMany(p => p.TRCZoneInfoProprietaireOrdinaire)
                    .HasForeignKey(d => d.ZpoCfCode)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireOrdinaire_T_C_ConservationFonciere");

                entity.HasOne(d => d.ZpoPo)
                    .WithMany(p => p.TRCZoneInfoProprietaireOrdinaire)
                    .HasForeignKey(d => d.ZpoPoId)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireOrdinaire_T_C_ProprietaireOrdinaire");

                entity.HasOne(d => d.ZpoZi)
                    .WithMany(p => p.TRCZoneInfoProprietaireOrdinaire)
                    .HasForeignKey(d => d.ZpoZiId)
                    .HasConstraintName("FK_T_R_C_ZoneInfo_ProprietaireOrdinaire_T_C_ZONE_INFOS");
            });

            modelBuilder.Entity<TREInfoEcheanceCentre>(entity =>
            {
                entity.HasKey(e => e.InfoId)
                    .HasName("PK_T_R_Info_Echeance_Centre");

                entity.ToTable("T_R_E_Info_Echeance_Centre");

                entity.Property(e => e.InfoId)
                    .HasColumnName("INFO_ID")
                    .HasComment("Identifiant de la table concernée");

                entity.Property(e => e.CentId)
                    .HasColumnName("CENT_ID")
                    .HasComment("Identifiant de la table T_Centre_Electoral en tant que clé etrangere");

                entity.Property(e => e.EchId)
                    .HasColumnName("ECH_ID")
                    .HasComment("Identifiant de la table T_Echeance_Electorale en tant que clé etrangere");

                entity.Property(e => e.InfoBulNul)
                    .HasColumnName("INFO_BUL_NUL")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("le nombre des bulletins nuls concernant un centre electoral particulier");

                entity.Property(e => e.InfoNbreVotant)
                    .HasColumnName("INFO_NBRE_VOTANT")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Nombre de votant par centre elctorale");

                entity.Property(e => e.InfoSufExp)
                    .HasColumnName("INFO_SUF_EXP")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Suffrage exprimé pour un centre electoral");

                entity.HasOne(d => d.Cent)
                    .WithMany(p => p.TREInfoEcheanceCentre)
                    .HasForeignKey(d => d.CentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_R_E_Info_Echeance_Centre_T_E_Centre_Electoral");

                entity.HasOne(d => d.Ech)
                    .WithMany(p => p.TREInfoEcheanceCentre)
                    .HasForeignKey(d => d.EchId)
                    .HasConstraintName("FK_T_R_Info_Echeance_Centre_T_Centre_Electoral");
            });

            modelBuilder.Entity<TREResulatObtenuCentre>(entity =>
            {
                entity.HasKey(e => e.CcId)
                    .HasName("PK_T_R_Resulat_Obtenu_Centre");

                entity.ToTable("T_R_E_Resulat_Obtenu_Centre");

                entity.Property(e => e.CcId)
                    .HasColumnName("CC_ID")
                    .HasComment("Identifiant du resultat  obtenu par centre");

                entity.Property(e => e.CandId)
                    .HasColumnName("CAND_ID")
                    .HasComment("L'identifiant du candidat en tant que clé etrangere");

                entity.Property(e => e.CcNbreVoix)
                    .HasColumnName("CC_NBRE_VOIX")
                    .HasColumnType("numeric(18, 0)")
                    .HasComment("Nombre de voix Obtenu par centre");

                entity.Property(e => e.CentId)
                    .HasColumnName("CENT_ID")
                    .HasComment("L'identifiant du Centre electoral en tant que clé etrangere");

                entity.HasOne(d => d.Cand)
                    .WithMany(p => p.TREResulatObtenuCentre)
                    .HasForeignKey(d => d.CandId)
                    .HasConstraintName("FK_T_R_Resulat_Obtenu_Centre_T_Centre_Electoral");

                entity.HasOne(d => d.Cent)
                    .WithMany(p => p.TREResulatObtenuCentre)
                    .HasForeignKey(d => d.CentId)
                    .HasConstraintName("FK_T_R_E_Resulat_Obtenu_Centre_T_E_Centre_Electoral");
            });

            modelBuilder.Entity<TRSonQuestionpopulation>(entity =>
            {
                entity.HasKey(e => e.QuespopId)
                    .HasName("PK_T_SON_R_POPULATION_REPONSE");

                entity.ToTable("T_R_SON_QUESTIONPOPULATION");

                entity.Property(e => e.QuespopId).HasColumnName("QUESPOP_ID");

                entity.Property(e => e.QuespopPopId).HasColumnName("QUESPOP_POP_ID");

                entity.Property(e => e.QuespopQuesId).HasColumnName("QUESPOP_QUES_ID");

                entity.Property(e => e.QuespopReponse).HasColumnName("QUESPOP_REPONSE");

                entity.HasOne(d => d.QuespopPop)
                    .WithMany(p => p.TRSonQuestionpopulation)
                    .HasForeignKey(d => d.QuespopPopId)
                    .HasConstraintName("FK_T_SON_R_QUEQTION_POULATION_T_SON_POPULATION");

                entity.HasOne(d => d.QuespopQues)
                    .WithMany(p => p.TRSonQuestionpopulation)
                    .HasForeignKey(d => d.QuespopQuesId)
                    .HasConstraintName("FK_T_SON_R_QUEQTION_POULATION_T_SON_QUESTION");
            });

            modelBuilder.Entity<TReferencePropriete>(entity =>
            {
                entity.HasKey(e => e.RefpId);

                entity.ToTable("T_REFERENCE_PROPRIETE");

                entity.Property(e => e.RefpId)
                    .HasColumnName("REFP_ID")
                    .HasComment("id de la propriété (propriétaire de un référencement)");

                entity.Property(e => e.RefpProId)
                    .HasColumnName("REFP_PRO_ID")
                    .HasComment("identifiant du propriétaire");

                entity.Property(e => e.RefpRefId)
                    .HasColumnName("REFP_REF_ID")
                    .HasComment("identifiant de l'espace");

                entity.Property(e => e.RespDate)
                    .HasColumnName("RESP_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date du début de propriété");

                entity.HasOne(d => d.RefpPro)
                    .WithMany(p => p.TReferencePropriete)
                    .HasForeignKey(d => d.RefpProId)
                    .HasConstraintName("FK_T_REFERENCE_PROPRIETE_T_PROPRIETAIRE");

                entity.HasOne(d => d.RefpRef)
                    .WithMany(p => p.TReferencePropriete)
                    .HasForeignKey(d => d.RefpRefId)
                    .HasConstraintName("FK_T_REFERENCE_PROPRIETE_T_RES_REFERENCEMENT");
            });

            modelBuilder.Entity<TResActivite>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("T_RES_ACTIVITE");

                entity.HasIndex(e => e.ActCode)
                    .HasName("IX_T_RES_ACTIVITE");

                entity.Property(e => e.ActId)
                    .HasColumnName("ACT_ID")
                    .HasComment("identifiant de l'activité");

                entity.Property(e => e.ActBOdp)
                    .HasColumnName("ACT_bODP")
                    .HasDefaultValueSql("((0))")
                    .HasComment("vrai indique que l'activité est pour ODP");

                entity.Property(e => e.ActCode)
                    .HasColumnName("ACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActDescription)
                    .HasColumnName("ACT_DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasComment("description de l'activité");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé de l'activité");

                entity.Property(e => e.ActTaxeMoyenneAn).HasColumnName("ACT_TAXE_MOYENNE_AN");

                entity.Property(e => e.ActTaxeMoyenneJour).HasColumnName("ACT_TAXE_MOYENNE_JOUR");

                entity.Property(e => e.ActTaxeMoyenneMois).HasColumnName("ACT_TAXE_MOYENNE_MOIS");
            });

            modelBuilder.Entity<TResActivitecontribuable>(entity =>
            {
                entity.HasKey(e => e.ActcontId);

                entity.ToTable("T_RES_ACTIVITECONTRIBUABLE");

                entity.Property(e => e.ActcontId)
                    .HasColumnName("ACTCONT_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.ActconAgentDecision)
                    .HasColumnName("ACTCON_AGENT_DECISION")
                    .HasComment("Nom  de l'agent ayant pris la décision");

                entity.Property(e => e.ActconDatePriseDecision)
                    .HasColumnName("ACTCON_DATE_PRISE_DECISION")
                    .HasColumnType("date")
                    .HasComment("Date de prise de décision");

                entity.Property(e => e.ActcontActId)
                    .HasColumnName("ACTCONT_ACT_ID")
                    .HasComment("identifiant de l'activité concernée");

                entity.Property(e => e.ActcontActiviteId)
                    .HasColumnName("ACTCONT_ACTIVITE_ID")
                    .HasComment("identifiant de l'activité issue de l'importation des données d'enquête");

                entity.Property(e => e.ActcontAgentFermetureDemande)
                    .HasColumnName("ACTCONT_AGENT_FERMETURE_DEMANDE")
                    .HasComment("identifiant l'agent ayant introduit la fermeture de l'activité");

                entity.Property(e => e.ActcontAgentIntroDemande)
                    .HasColumnName("ACTCONT_AGENT_INTRO_DEMANDE")
                    .HasComment("identifiant de l'agent introduisant la demande");

                entity.Property(e => e.ActcontBDecisionFermeture)
                    .HasColumnName("ACTCONT_bDECISION_FERMETURE")
                    .HasDefaultValueSql("((0))")
                    .HasComment("est vrai indique que la procédure de fermeture a été approuvée");

                entity.Property(e => e.ActcontBDecisionMes)
                    .HasColumnName("ACTCONT_bDECISION_MES")
                    .HasComment("Permet de savoir si la décision est mise en service ou pas");

                entity.Property(e => e.ActcontBOdp)
                    .HasColumnName("ACTCONT_bODP")
                    .HasComment("indique si l'activité se fait sur le domaine public");

                entity.Property(e => e.ActcontContId)
                    .HasColumnName("ACTCONT_CONT_ID")
                    .HasComment("l'identifiant du contribuable associé à l'activité");

                entity.Property(e => e.ActcontDateFermetureDemande)
                    .HasColumnName("ACTCONT_DATE_FERMETURE_DEMANDE")
                    .HasColumnType("date")
                    .HasComment("date de demande de fermeture de l'activité");

                entity.Property(e => e.ActcontDateIntroDemande)
                    .HasColumnName("ACTCONT_DATE_INTRO_DEMANDE")
                    .HasColumnType("date")
                    .HasComment("Date d'introduction de la demande du contribuable");

                entity.Property(e => e.ActcontFermetureRaison)
                    .HasColumnName("ACTCONT_FERMETURE_RAISON")
                    .IsUnicode(false)
                    .HasComment("la raison évoquée pour la demande de fermeture");

                entity.Property(e => e.ActcontNom)
                    .HasColumnName("ACTCONT_NOM")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Nom de l'activité (exple: boite de nuit du nom de PIMENT NIGHT CLUB)");

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("l'immatriculation représente un numéro unique permanent associé à une activité et un contribuable spécifique. Il est constitué du numéro de référence du local concatené à \"_\" et i, i étant une incrémentation");

                entity.Property(e => e.ActcontPlaqueOld)
                    .HasColumnName("ACTCONT_PLAQUE_OLD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontRefId)
                    .HasColumnName("ACTCONT_REF_ID")
                    .HasComment("identifiant du referencement (indique si activité ODP, ou a lieu dans CENTRE COMMERCIAL, ou MARCHE ET si l'activité est sur une TABLE, un MAGASIN, ...)");

                entity.Property(e => e.ActcontZoneId)
                    .HasColumnName("ACTCONT_ZONE_ID")
                    .HasComment("identifiant de la zone d'exécution de l'activité");

                entity.Property(e => e.ActontAgentFermetureDecision)
                    .HasColumnName("ACTONT_AGENT_FERMETURE_DECISION")
                    .HasColumnType("date")
                    .HasComment("agent ayant pris la décision de fermeture");

                entity.Property(e => e.ActontDateFermetureDecision)
                    .HasColumnName("ACTONT_DATE_FERMETURE_DECISION")
                    .HasColumnType("date")
                    .HasComment("date de prise de décision pour la fermeture ");

                entity.HasOne(d => d.ActcontAct)
                    .WithMany(p => p.TResActivitecontribuable)
                    .HasForeignKey(d => d.ActcontActId)
                    .HasConstraintName("FK_T_RES_ACTIVITECONTRIBUABLE_T_RES_ACTIVITE");

                entity.HasOne(d => d.ActcontCont)
                    .WithMany(p => p.TResActivitecontribuable)
                    .HasForeignKey(d => d.ActcontContId)
                    .HasConstraintName("FK_T_RES_ACTIVITECONTRIBUABLE_T_C_Contribuable");

                entity.HasOne(d => d.ActcontZone)
                    .WithMany(p => p.TResActivitecontribuable)
                    .HasForeignKey(d => d.ActcontZoneId)
                    .HasConstraintName("FK_T_RES_ACTIVITECONTRIBUABLE_T_ZONE");
            });

            modelBuilder.Entity<TResAvoir>(entity =>
            {
                entity.HasKey(e => e.AvoirId);

                entity.ToTable("T_RES_AVOIR");

                entity.Property(e => e.AvoirId).HasColumnName("AVOIR_ID");

                entity.Property(e => e.AvoirContId).HasColumnName("AVOIR_CONT_ID");

                entity.Property(e => e.AvoirFactId).HasColumnName("AVOIR_FACT_ID");

                entity.Property(e => e.AvoirMontant).HasColumnName("AVOIR_MONTANT");
            });

            modelBuilder.Entity<TResCollecte>(entity =>
            {
                entity.HasKey(e => e.ColId);

                entity.ToTable("T_RES_COLLECTE");

                entity.Property(e => e.ColId)
                    .HasColumnName("COL_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.ColAcolId)
                    .HasColumnName("COL_ACOL_ID")
                    .HasComment("identifiant de l'agent collecteur qui a réalisé la récolte sur le terrain");

                entity.Property(e => e.ColActcontId)
                    .HasColumnName("COL_ACTCONT_ID")
                    .HasComment("identifiant de l'activité du contribuable concerné");

                entity.Property(e => e.ColAgId)
                    .HasColumnName("COL_AG_ID")
                    .HasComment("identifiant de l'agent qui fait l'opération");

                entity.Property(e => e.ColBExportPaiement)
                    .HasColumnName("COL_bEXPORT_PAIEMENT")
                    .HasComment("VRAI indique que la ligne a été exportée avec succès vers la table PAIEMENT (collecte prise en compte dans la recette)");

                entity.Property(e => e.ColDate)
                    .HasColumnName("COL_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date de la collecte");

                entity.Property(e => e.ColFactId)
                    .HasColumnName("COL_FACT_ID")
                    .HasComment("identifiant de la facture à l'origine de cette ligne de collecte");

                entity.Property(e => e.ColMontant)
                    .HasColumnName("COL_MONTANT")
                    .HasComment("montant collecté");

                entity.Property(e => e.ColTaxId)
                    .HasColumnName("COL_TAX_ID")
                    .HasComment("identifiant de la taxe concernée");

                entity.HasOne(d => d.ColAcol)
                    .WithMany(p => p.TResCollecte)
                    .HasForeignKey(d => d.ColAcolId)
                    .HasConstraintName("FK_T_RES_COLLECTE_T_AGENT_COLLECTEUR");

                entity.HasOne(d => d.ColAg)
                    .WithMany(p => p.TResCollecte)
                    .HasForeignKey(d => d.ColAgId)
                    .HasConstraintName("FK_T_RES_COLLECTE_T_Agent");

                entity.HasOne(d => d.ColFact)
                    .WithMany(p => p.TResCollecte)
                    .HasForeignKey(d => d.ColFactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_RES_COLLECTE_T_RES_FACTURE");

                entity.HasOne(d => d.ColTax)
                    .WithMany(p => p.TResCollecte)
                    .HasForeignKey(d => d.ColTaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_RES_COLLECTE_T_RES_TAXE");
            });

            modelBuilder.Entity<TResEspaceExploitable>(entity =>
            {
                entity.HasKey(e => e.EspId);

                entity.ToTable("T_RES_ESPACE_EXPLOITABLE");

                entity.Property(e => e.EspId)
                    .HasColumnName("ESP_ID")
                    .HasComment("Identifiant espace exploitable");

                entity.Property(e => e.EspDescription)
                    .HasColumnName("ESP_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de l'espace exploitable");

                entity.Property(e => e.EspLibelle)
                    .HasColumnName("ESP_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de l'espace exploitable (MARCHE CENTRAL MARCORY, MARCHE DE NUIT, ESPACE POLYGONE, PRIMA CENTER,...)");

                entity.Property(e => e.EspTaId).HasColumnName("ESP_TA_ID");

                entity.HasOne(d => d.EspTa)
                    .WithMany(p => p.TResEspaceExploitable)
                    .HasForeignKey(d => d.EspTaId)
                    .HasConstraintName("FK_T_RES_ESPACE_EXPLOITABLE_T_RES_TYPE_ACTIVITE");
            });

            modelBuilder.Entity<TResFacture>(entity =>
            {
                entity.HasKey(e => e.FactId);

                entity.ToTable("T_RES_FACTURE");

                entity.HasIndex(e => e.FactCode)
                    .HasName("IX_T_RES_FACTURE")
                    .IsUnique();

                entity.Property(e => e.FactId)
                    .HasColumnName("FACT_ID")
                    .HasComment("identifiant de la facture");

                entity.Property(e => e.FactAbandonAgId)
                    .HasColumnName("FACT_ABANDON_AG_ID")
                    .HasComment("l'agent ayant ordonné l'abandon de la facture");

                entity.Property(e => e.FactAbandonMotif)
                    .HasColumnName("FACT_ABANDON_MOTIF")
                    .IsUnicode(false)
                    .HasComment("le motif de l'abandon de la facture");

                entity.Property(e => e.FactActId)
                    .HasColumnName("FACT_ACT_ID")
                    .HasComment("identifiant de l'activité concernée (information accessible à partir de TAXACT_ID, mais le non respect de la forme normale est faite pour l'optimisation de requete)");

                entity.Property(e => e.FactBAbandon)
                    .HasColumnName("FACT_bABANDON")
                    .HasComment("indique que la facture est abandonnée, le règlement n'est plus réquis");

                entity.Property(e => e.FactBEtatReglement)
                    .HasColumnName("FACT_bETAT_REGLEMENT")
                    .HasComment("booléen indiquant si la facture a été réglée");

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("code de la facture, imprimé sur la facture");

                entity.Property(e => e.FactContId)
                    .HasColumnName("FACT_CONT_ID")
                    .HasComment("identifiant du contribuable concerné (information accessible à partir de TAXACT_ID, mais le non respect de la forme normale est faite pour l'optimisation de requete)");

                entity.Property(e => e.FactCpteId).HasColumnName("FACT_CPTE_ID");

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime")
                    .HasComment("date limite à laquelle la facture doit être payée");

                entity.Property(e => e.FactDateEmission)
                    .HasColumnName("FACT_DATE_EMISSION")
                    .HasColumnType("datetime")
                    .HasComment("date d'émission de la facture");

                entity.Property(e => e.FactDateaBandon)
                    .HasColumnName("FACT_DATEA_BANDON")
                    .HasColumnType("date")
                    .HasComment("la date d'abandon de la facture");

                entity.Property(e => e.FactLibelle)
                    .IsRequired()
                    .HasColumnName("FACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("le libellé de la facture");

                entity.Property(e => e.FactMontant)
                    .HasColumnName("FACT_MONTANT")
                    .HasComment("le montant de la facture");

                entity.Property(e => e.FactPeriodeDebut)
                    .HasColumnName("FACT_PERIODE_DEBUT")
                    .HasColumnType("datetime")
                    .HasComment("début de période facturée");

                entity.Property(e => e.FactPeriodeFin)
                    .HasColumnName("FACT_PERIODE_FIN")
                    .HasColumnType("datetime")
                    .HasComment("fin de période facturée");

                entity.Property(e => e.FactPotentiel).HasColumnName("FACT_POTENTIEL");

                entity.Property(e => e.FactTaxactId)
                    .HasColumnName("FACT_TAXACT_ID")
                    .HasComment("identifiant de la relation taxe-activite pour savoir quelle taxe et quelle activité sont concernées");

                entity.HasOne(d => d.FactAct)
                    .WithMany(p => p.TResFacture)
                    .HasForeignKey(d => d.FactActId)
                    .HasConstraintName("FK_T_RES_FACTURE_T_RES_ACTIVITE");

                entity.HasOne(d => d.FactCont)
                    .WithMany(p => p.TResFacture)
                    .HasForeignKey(d => d.FactContId)
                    .HasConstraintName("FK_T_RES_FACTURE_T_C_Contribuable");

                entity.HasOne(d => d.FactTaxact)
                    .WithMany(p => p.TResFacture)
                    .HasForeignKey(d => d.FactTaxactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_RES_FACTURE_T_RES_TAXEACTIVITE");
            });

            modelBuilder.Entity<TResMetafacture>(entity =>
            {
                entity.HasKey(e => e.MefaId);

                entity.ToTable("T_RES_METAFACTURE");

                entity.Property(e => e.MefaId)
                    .HasColumnName("MEFA_ID")
                    .HasComment("identifiant de l'enregistrement");

                entity.Property(e => e.MefaAgId)
                    .HasColumnName("MEFA_AG_ID")
                    .HasComment("identifiant de l'agent ayant réalisé la métafacture");

                entity.Property(e => e.MefaCode)
                    .HasColumnName("MEFA_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("code de la métafacture");

                entity.Property(e => e.MefaDate)
                    .HasColumnName("MEFA_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date d'établissement");

                entity.HasOne(d => d.MefaAg)
                    .WithMany(p => p.TResMetafacture)
                    .HasForeignKey(d => d.MefaAgId)
                    .HasConstraintName("FK_T_RES_METAFACTURE_T_Agent");
            });

            modelBuilder.Entity<TResPaiement>(entity =>
            {
                entity.HasKey(e => e.PaieId);

                entity.ToTable("T_RES_PAIEMENT");

                entity.Property(e => e.PaieId)
                    .HasColumnName("PAIE_ID")
                    .HasComment("identifiant de la transaction");

                entity.Property(e => e.PaieColId)
                    .HasColumnName("PAIE_COL_ID")
                    .HasComment("identifiant de la collecte, est renseigné sur le paiement s'est fait à la suite d'une collecte par les agents de la mairie sur le terrain");

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date paiement");

                entity.Property(e => e.PaieFactAgId)
                    .HasColumnName("PAIE_FACT_AG_ID")
                    .HasComment("identifiant de l'agent ayant réalisé l'opération");

                entity.Property(e => e.PaieFactId)
                    .HasColumnName("PAIE_FACT_ID")
                    .HasComment("identifiant de la facture concernée");

                entity.Property(e => e.PaieMontant)
                    .HasColumnName("PAIE_MONTANT")
                    .HasComment("somme payée");

                entity.Property(e => e.PaieScValId)
                    .HasColumnName("PAIE_SC_VAL_ID")
                    .HasComment("exploité si le montant payé est relatif à une contravention. Sauvegarde la valeur du montant payé de la contravention stocké dans la table T_S_CONT_VALEUR");

                entity.HasOne(d => d.PaieCol)
                    .WithMany(p => p.TResPaiement)
                    .HasForeignKey(d => d.PaieColId)
                    .HasConstraintName("FK_T_RES_PAIEMENT_T_RES_COLLECTE");

                entity.HasOne(d => d.PaieFact)
                    .WithMany(p => p.TResPaiement)
                    .HasForeignKey(d => d.PaieFactId)
                    .HasConstraintName("FK_T_RES_PAIEMENT_T_RES_FACTURE");

                entity.HasOne(d => d.PaieScVal)
                    .WithMany(p => p.TResPaiement)
                    .HasForeignKey(d => d.PaieScValId)
                    .HasConstraintName("FK_T_RES_PAIEMENT_T_S_CONT_VALEUR");
            });

            modelBuilder.Entity<TResRFactureMetafacture>(entity =>
            {
                entity.HasKey(e => e.FacmetafactId);

                entity.ToTable("T_RES_R_FACTURE_METAFACTURE");

                entity.Property(e => e.FacmetafactId)
                    .HasColumnName("FACMETAFACT_ID")
                    .HasComment("identifiant de la table de relation FACTURE et METAFACTURE");

                entity.Property(e => e.FactmetafactFactId)
                    .HasColumnName("FACTMETAFACT_FACT_ID")
                    .HasComment("identifiant de la facture concernée");

                entity.Property(e => e.FactmetafactMefaId)
                    .HasColumnName("FACTMETAFACT_MEFA_ID")
                    .HasComment("identifiant de la facture concernée");

                entity.HasOne(d => d.FactmetafactFact)
                    .WithMany(p => p.TResRFactureMetafacture)
                    .HasForeignKey(d => d.FactmetafactFactId)
                    .HasConstraintName("FK_T_RES_R_FACTURE_METAFACTURE_T_RES_FACTURE");

                entity.HasOne(d => d.FactmetafactMefa)
                    .WithMany(p => p.TResRFactureMetafacture)
                    .HasForeignKey(d => d.FactmetafactMefaId)
                    .HasConstraintName("FK_T_RES_R_FACTURE_METAFACTURE_T_RES_METAFACTURE");
            });

            modelBuilder.Entity<TResReferencement>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.ToTable("T_RES_REFERENCEMENT");

                entity.HasIndex(e => e.RefId)
                    .HasName("IX_T_RES_REFERENCEMENT")
                    .IsUnique();

                entity.Property(e => e.RefId)
                    .HasColumnName("REF_ID")
                    .HasComment("identifiant du referencement");

                entity.Property(e => e.RefAlpha)
                    .HasColumnName("REF_ALPHA")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("valeur alpha numerique associée au referencement (exple: numero immatriculation magasin pour un magasin de marché)");

                entity.Property(e => e.RefDescription)
                    .HasColumnName("REF_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de la référence");

                entity.Property(e => e.RefEspId)
                    .HasColumnName("REF_ESP_ID")
                    .HasComment("identifiant du nom de l'espace exploité");

                entity.Property(e => e.RefNumCntig)
                    .HasColumnName("REF_NUM_CNTIG")
                    .HasComment("numéro unique attribué à la fiche d'enquête réservée à un lot spécifique attribué par le CNTIG dans le cadre de l'enquête relative au projet E-COMMUNE");

                entity.Property(e => e.RefNumMairie)
                    .HasColumnName("REF_NUM_MAIRIE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("numéro attribué par la mairie à une fiche d'enquête devant permettre de receuillir des informations spécifiques sur le terrain");

                entity.Property(e => e.RefNumerique)
                    .HasColumnName("REF_NUMERIQUE")
                    .HasComment("valeur numérique associée au référencement (exple: superficie pour un local ODP)");

                entity.Property(e => e.RefTaId)
                    .HasColumnName("REF_TA_ID")
                    .HasComment("identifiant du type d'activité associé (ODP, Marché, ...)");

                entity.Property(e => e.RefTlId)
                    .HasColumnName("REF_TL_ID")
                    .HasComment("identifiant du type de local associé");

                entity.Property(e => e.RefValeur)
                    .IsRequired()
                    .HasColumnName("REF_VALEUR")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("valeur unique de la reference (exple: ORCA_MAG_1332) indiquant les informations relatives à l'espace exploité");

                entity.Property(e => e.RefZoneId).HasColumnName("REF_ZONE_ID");

                entity.HasOne(d => d.RefEsp)
                    .WithMany(p => p.TResReferencement)
                    .HasForeignKey(d => d.RefEspId)
                    .HasConstraintName("FK_T_RES_REFERENCEMENT_T_RES_ESPACE_EXPLOITABLE");

                entity.HasOne(d => d.RefTa)
                    .WithMany(p => p.TResReferencement)
                    .HasForeignKey(d => d.RefTaId)
                    .HasConstraintName("FK_T_RES_REFERENCEMENT_T_RES_TYPE_ACTIVITE");

                entity.HasOne(d => d.RefTl)
                    .WithMany(p => p.TResReferencement)
                    .HasForeignKey(d => d.RefTlId)
                    .HasConstraintName("FK_T_RES_REFERENCEMENT_T_RES_TYPE_LOCAL");

                entity.HasOne(d => d.RefZone)
                    .WithMany(p => p.TResReferencement)
                    .HasForeignKey(d => d.RefZoneId)
                    .HasConstraintName("FK_T_RES_REFERENCEMENT_T_ZONE");
            });

            modelBuilder.Entity<TResTaxactiviteDefaut>(entity =>
            {
                entity.HasKey(e => e.TaxactId);

                entity.ToTable("T_RES_TAXACTIVITE_DEFAUT");

                entity.Property(e => e.TaxactId)
                    .HasColumnName("TAXACT_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.TaxactActId)
                    .HasColumnName("TAXACT_ACT_ID")
                    .HasComment("identifiant de l'activité concernée");

                entity.Property(e => e.TaxactTaxId)
                    .HasColumnName("TAXACT_TAX_ID")
                    .HasComment("identifiant de la taxe par défaut concernée");

                entity.HasOne(d => d.TaxactAct)
                    .WithMany(p => p.TResTaxactiviteDefaut)
                    .HasForeignKey(d => d.TaxactActId)
                    .HasConstraintName("FK_T_RES_TAXACTIVITE_DEFAUT_T_RES_ACTIVITE");

                entity.HasOne(d => d.TaxactTax)
                    .WithMany(p => p.TResTaxactiviteDefaut)
                    .HasForeignKey(d => d.TaxactTaxId)
                    .HasConstraintName("FK_T_RES_TAXACTIVITE_DEFAUT_T_RES_TAXE");
            });

            modelBuilder.Entity<TResTaxassiete>(entity =>
            {
                entity.HasKey(e => e.AssId);

                entity.ToTable("T_RES_TAXASSIETE");

                entity.Property(e => e.AssId)
                    .HasColumnName("ASS_ID")
                    .HasComment("identifiant de l'assiette")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssDescription)
                    .HasColumnName("ASS_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de l'assiète");

                entity.Property(e => e.AssLibelle)
                    .HasColumnName("ASS_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("libellé de l'assiette (ex: tête, bâtiment, ...)");
            });

            modelBuilder.Entity<TResTaxcompte>(entity =>
            {
                entity.HasKey(e => e.CpteCode);

                entity.ToTable("T_RES_TAXCOMPTE");

                entity.Property(e => e.CpteCode)
                    .HasColumnName("CPTE_CODE")
                    .HasComment("code du compte servant didentifiant")
                    .ValueGeneratedNever();

                entity.Property(e => e.CpteBActif)
                    .HasColumnName("CPTE_bACTIF")
                    .HasComment("indique si le compte est actif");

                entity.Property(e => e.CpteDescription)
                    .HasColumnName("CPTE_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description du compte");

                entity.Property(e => e.CpteIdparent)
                    .HasColumnName("CPTE_IDPARENT")
                    .HasComment("identifiant du compte parent auquel le compte courant est rattaché");

                entity.Property(e => e.CpteLibelle)
                    .HasColumnName("CPTE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé du compte");

                entity.HasOne(d => d.CpteIdparentNavigation)
                    .WithMany(p => p.InverseCpteIdparentNavigation)
                    .HasForeignKey(d => d.CpteIdparent)
                    .HasConstraintName("FK_T_RES_TAXCOMPTE_T_RES_TAXCOMPTE1");
            });

            modelBuilder.Entity<TResTaxe>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("T_RES_TAXE");

                entity.Property(e => e.TaxId)
                    .HasColumnName("TAX_ID")
                    .HasComment("Identifiant de la taxe");

                entity.Property(e => e.TaxBActif)
                    .HasColumnName("TAX_bACTIF")
                    .HasComment("indique que la taxe est active");

                entity.Property(e => e.TaxCpteCode)
                    .HasColumnName("TAX_CPTE_CODE")
                    .HasComment("code du compte auquel est rattaché la taxe");

                entity.Property(e => e.TaxDescription)
                    .HasColumnName("TAX_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de la taxe");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé de la taxe");

                entity.Property(e => e.TaxTaxfId)
                    .HasColumnName("TAX_TAXF_ID")
                    .HasComment("identifiant de la famille de taxe associée");

                entity.HasOne(d => d.TaxCpteCodeNavigation)
                    .WithMany(p => p.TResTaxe)
                    .HasForeignKey(d => d.TaxCpteCode)
                    .HasConstraintName("FK_T_RES_TAXE_T_RES_TAXCOMPTE");

                entity.HasOne(d => d.TaxTaxf)
                    .WithMany(p => p.TResTaxe)
                    .HasForeignKey(d => d.TaxTaxfId)
                    .HasConstraintName("FK_T_RES_TAXE_T_RES_TAXE_FAMILLE");
            });

            modelBuilder.Entity<TResTaxeFamille>(entity =>
            {
                entity.HasKey(e => e.TaxfId);

                entity.ToTable("T_RES_TAXE_FAMILLE");

                entity.Property(e => e.TaxfId)
                    .HasColumnName("TAXF_ID")
                    .HasComment("identifiant de la famille de taxe");

                entity.Property(e => e.TaxfDescription)
                    .HasColumnName("TAXF_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("description de la taxe");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de taxe");

                entity.Property(e => e.TaxfUrlImage)
                    .HasColumnName("TAXF_URL_IMAGE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("adresse de l'image associée utilisée pour les rapports imprimés");
            });

            modelBuilder.Entity<TResTaxeactivite>(entity =>
            {
                entity.HasKey(e => e.TaxactId);

                entity.ToTable("T_RES_TAXEACTIVITE");

                entity.Property(e => e.TaxactId)
                    .HasColumnName("TAXACT_ID")
                    .HasComment("identifiant");

                entity.Property(e => e.TaxactActId).HasColumnName("TAXACT_ACT_ID");

                entity.Property(e => e.TaxactActcontId)
                    .HasColumnName("TAXACT_ACTCONT_ID")
                    .HasComment("identifiant de l'activité du contribuable concerné");

                entity.Property(e => e.TaxactPlaque)
                    .HasColumnName("TAXACT_PLAQUE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("une chaîne de caractère attribuée par l'organisation à un contribuable pour une taxe précise");

                entity.Property(e => e.TaxactTaxId)
                    .HasColumnName("TAXACT_TAX_ID")
                    .HasComment("identifiant de la taxe concernée");

                entity.HasOne(d => d.TaxactAct)
                    .WithMany(p => p.TResTaxeactivite)
                    .HasForeignKey(d => d.TaxactActId)
                    .HasConstraintName("FK_T_RES_TAXEACTIVITE_T_ACTIVITE");
            });

            modelBuilder.Entity<TResTaxeactiviteDefaut>(entity =>
            {
                entity.HasKey(e => e.TaxactId);

                entity.ToTable("T_RES_TAXEACTIVITE_DEFAUT");

                entity.Property(e => e.TaxactId)
                    .HasColumnName("TAXACT_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.TaxactActId)
                    .HasColumnName("TAXACT_ACT_ID")
                    .HasComment("identifiant de l'activité concernée");

                entity.Property(e => e.TaxactTaxId)
                    .HasColumnName("TAXACT_TAX_ID")
                    .HasComment("identifiant de la taxe par défaut concernée");
            });

            modelBuilder.Entity<TResTaxperiodicite>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK_T_RES_PERIODICITE");

                entity.ToTable("T_RES_TAXPERIODICITE");

                entity.Property(e => e.PerId)
                    .HasColumnName("PER_ID")
                    .HasComment("identifiant de la période");

                entity.Property(e => e.PerAnnee)
                    .HasColumnName("PER_ANNEE")
                    .HasComment("vrai indique que la périodicité est par ANNEE");

                entity.Property(e => e.PerHeure)
                    .HasColumnName("PER_HEURE")
                    .HasComment("VRAI indique que la périodicité est horaire");

                entity.Property(e => e.PerJour)
                    .HasColumnName("PER_JOUR")
                    .HasComment("vrai indique la périodicité est par JOUR");

                entity.Property(e => e.PerLibelle)
                    .HasColumnName("PER_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("libellé de la périodicité");

                entity.Property(e => e.PerMois)
                    .HasColumnName("PER_MOIS")
                    .HasComment("vrai indique que la périodicité est par MOIS");

                entity.Property(e => e.PerUnique)
                    .HasColumnName("PER_UNIQUE")
                    .HasComment("vrai indique qu'il n'y a pas de périodicité, la taxe associée se paie UNE FOIS POUR TOUTE");

                entity.Property(e => e.PerValeur)
                    .HasColumnName("PER_VALEUR")
                    .HasComment("la valeur de la périodicité");
            });

            modelBuilder.Entity<TResTaxvaleur>(entity =>
            {
                entity.HasKey(e => e.ValId);

                entity.ToTable("T_RES_TAXVALEUR");

                entity.Property(e => e.ValId)
                    .HasColumnName("VAL_ID")
                    .HasComment("identifiant de la valeur de la taxe");

                entity.Property(e => e.ValAssId)
                    .HasColumnName("VAL_ASS_ID")
                    .HasComment("identifiant de l'assiette associée");

                entity.Property(e => e.ValBValide)
                    .HasColumnName("VAL_bValide")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValDateapplication)
                    .HasColumnName("VAL_DATEAPPLICATION")
                    .HasColumnType("date")
                    .HasComment("date d'entrée en vigeur de la taxe");

                entity.Property(e => e.ValPerId)
                    .HasColumnName("VAL_PER_ID")
                    .HasComment("identifiant de la période associée");

                entity.Property(e => e.ValTaux)
                    .HasColumnName("VAL_TAUX")
                    .HasComment("valeur numérique de la taxe (peut être montant fixe, ratio, ...)");

                entity.Property(e => e.ValTaxId)
                    .HasColumnName("VAL_TAX_ID")
                    .HasComment("identifiant de la taxe associée");

                entity.HasOne(d => d.ValAss)
                    .WithMany(p => p.TResTaxvaleur)
                    .HasForeignKey(d => d.ValAssId)
                    .HasConstraintName("FK_T_RES_TAXVALEUR_T_RES_TAXASSIETE");

                entity.HasOne(d => d.ValPer)
                    .WithMany(p => p.TResTaxvaleur)
                    .HasForeignKey(d => d.ValPerId)
                    .HasConstraintName("FK_T_RES_TAXVALEUR_T_RES_TAXPERIODICITE");

                entity.HasOne(d => d.ValTax)
                    .WithMany(p => p.TResTaxvaleur)
                    .HasForeignKey(d => d.ValTaxId)
                    .HasConstraintName("FK_T_RES_TAXVALEUR_T_RES_TAXE");
            });

            modelBuilder.Entity<TResTypeActivite>(entity =>
            {
                entity.HasKey(e => e.TaId);

                entity.ToTable("T_RES_TYPE_ACTIVITE");

                entity.Property(e => e.TaId)
                    .HasColumnName("TA_ID")
                    .HasComment("identifiant du type d'activité");

                entity.Property(e => e.TaCode)
                    .IsRequired()
                    .HasColumnName("TA_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NEANT')")
                    .HasComment("le code du type d'activité (en fait type d'espace) utilisé pour la génération du code de reference unique (exple: MARCHE => MCHE)");

                entity.Property(e => e.TaDescription)
                    .HasColumnName("TA_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description du type d'activité");

                entity.Property(e => e.TaLibelle)
                    .HasColumnName("TA_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du type d'activité (ODP,Centre Commercial,  Autres, ...)");
            });

            modelBuilder.Entity<TResTypeLocal>(entity =>
            {
                entity.HasKey(e => e.TlId);

                entity.ToTable("T_RES_TYPE_LOCAL");

                entity.Property(e => e.TlId)
                    .HasColumnName("TL_ID")
                    .HasComment("identifiant du type de local");

                entity.Property(e => e.TlCode)
                    .HasColumnName("TL_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("le code du type de local utilisé pour la génération automatique d'un code de reference (exple: MAGASIN => MAG)");

                entity.Property(e => e.TlDescription)
                    .HasColumnName("TL_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description du type du local");

                entity.Property(e => e.TlLibelle)
                    .HasColumnName("TL_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du type du local (table, box, magasin, salle, ...)");

                entity.Property(e => e.TlLibelleAlpha)
                    .HasColumnName("TL_LIBELLE_ALPHA")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("en fonction du type de local, on pourrait conserver une information alphanumérique importante (exple: MAGASIN ODP, on conserver N° MAGASIN)");

                entity.Property(e => e.TlLibelleNumerique)
                    .HasColumnName("TL_LIBELLE_NUMERIQUE")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("en fonction du type de local, il pourrait avoir des informations importantes numériques à conserver. Ce champ défini le libéllé de cette information (exple: magasin ODP, on conversvera SUPERFICIE en m2)");
            });

            modelBuilder.Entity<TSCamera>(entity =>
            {
                entity.HasKey(e => e.CamId);

                entity.ToTable("T_S_CAMERA");

                entity.Property(e => e.CamId)
                    .HasColumnName("CAM_ID")
                    .HasComment("Identifiant d'une caméra");

                entity.Property(e => e.CamAdresse)
                    .HasColumnName("CAM_ADRESSE")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("adresse réseau d'une caméra utilisée pour accéder aux images transmises");

                entity.Property(e => e.CamBFonctionel)
                    .HasColumnName("CAM_bFONCTIONEL")
                    .HasDefaultValueSql("((0))")
                    .HasComment("booléen indiquant que la caméra est active ou non");

                entity.Property(e => e.CamDateMiseEnService)
                    .HasColumnName("CAM_DATE_MISE_EN_SERVICE")
                    .HasColumnType("date")
                    .HasComment("la date de mise en service de la caméra");

                entity.Property(e => e.CamDescription)
                    .HasColumnName("CAM_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("une description libre de la caméra");

                entity.Property(e => e.CamLibelle)
                    .HasColumnName("CAM_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé d'une caméra");

                entity.Property(e => e.CamZoneId)
                    .HasColumnName("CAM_ZONE_ID")
                    .HasComment("identifiant de la zone géographique concernée couverte par la caméra");

                entity.HasOne(d => d.CamZone)
                    .WithMany(p => p.TSCamera)
                    .HasForeignKey(d => d.CamZoneId)
                    .HasConstraintName("FK_T_S_CAMERA_T_ZONE");
            });

            modelBuilder.Entity<TSContCategorie>(entity =>
            {
                entity.HasKey(e => e.ScCatId);

                entity.ToTable("T_S_CONT_CATEGORIE");

                entity.Property(e => e.ScCatId)
                    .HasColumnName("SC_CAT_ID")
                    .HasComment("identifiant d'une catégorie associée aux contraventions");

                entity.Property(e => e.ScCatBSecurite)
                    .HasColumnName("SC_CAT_bSecurite")
                    .HasDefaultValueSql("((0))")
                    .HasComment("booléen indiquant si les contraventions indexées sont relatives à la sécurité dans la commune");

                entity.Property(e => e.ScCatDescription)
                    .HasColumnName("SC_CAT_DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("description d'une catégorie");

                entity.Property(e => e.ScCatLibelle)
                    .HasColumnName("SC_CAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé d'une catégorie");
            });

            modelBuilder.Entity<TSContContravention>(entity =>
            {
                entity.HasKey(e => e.ScContId);

                entity.ToTable("T_S_CONT_CONTRAVENTION");

                entity.Property(e => e.ScContId)
                    .HasColumnName("SC_CONT_ID")
                    .HasComment("identifiant d'une contravention");

                entity.Property(e => e.ScContDescription)
                    .HasColumnName("SC_CONT_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description associée à une contravention");

                entity.Property(e => e.ScContLibelle)
                    .HasColumnName("SC_CONT_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("libellé d'une contravention");

                entity.Property(e => e.ScContScScatId).HasColumnName("SC_CONT_SC_SCAT_ID");

                entity.HasOne(d => d.ScContScScat)
                    .WithMany(p => p.TSContContravention)
                    .HasForeignKey(d => d.ScContScScatId)
                    .HasConstraintName("FK_T_S_CONT_CONTRAVENTION_T_S_CONT_SOUSCATEGORIE");
            });

            modelBuilder.Entity<TSContMontant>(entity =>
            {
                entity.HasKey(e => e.ScMonId)
                    .HasName("PK_T_S_C_CONT_MONTANT");

                entity.ToTable("T_S_CONT_MONTANT");

                entity.Property(e => e.ScMonId)
                    .HasColumnName("SC_MON_ID")
                    .HasComment("identifiant d'un montant associé à une contravention");

                entity.Property(e => e.ScMonContId)
                    .HasColumnName("SC_MON_CONT_ID")
                    .HasComment("identifiant de la contravention associée");

                entity.Property(e => e.ScMonDate)
                    .HasColumnName("SC_MON_DATE")
                    .HasColumnType("date")
                    .HasComment("date d'application de la valeur d'une contravention (on suppose qu'une contravention peut voir sa valeur évoluée dans le temps)");

                entity.Property(e => e.ScMonValeur)
                    .HasColumnName("SC_MON_VALEUR")
                    .HasComment("valeur associée à une contravention");

                entity.HasOne(d => d.ScMonCont)
                    .WithMany(p => p.TSContMontant)
                    .HasForeignKey(d => d.ScMonContId)
                    .HasConstraintName("FK_T_S_C_CONT_MONTANT_T_S_CONT_CONTRAVENTION");
            });

            modelBuilder.Entity<TSContSouscategorie>(entity =>
            {
                entity.HasKey(e => e.ScScatId);

                entity.ToTable("T_S_CONT_SOUSCATEGORIE");

                entity.Property(e => e.ScScatId)
                    .HasColumnName("SC_SCAT_ID")
                    .HasComment("identifiant d'une sous catégorie associée à une catégorie d'intervention");

                entity.Property(e => e.ScScatDescription)
                    .HasColumnName("SC_SCAT_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description d'une sous catégorie");

                entity.Property(e => e.ScScatLibelle)
                    .HasColumnName("SC_SCAT_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasComment("libellé d'une sous catégorie");

                entity.Property(e => e.ScScatScCatId)
                    .HasColumnName("SC_SCAT_SC_CAT_ID")
                    .HasComment("identifiant d'une catégorie relative aux contraventions");

                entity.HasOne(d => d.ScScatScCat)
                    .WithMany(p => p.TSContSouscategorie)
                    .HasForeignKey(d => d.ScScatScCatId)
                    .HasConstraintName("FK_T_S_CONT_SOUSCATEGORIE_T_S_CONT_CATEGORIE");
            });

            modelBuilder.Entity<TSContValeur>(entity =>
            {
                entity.HasKey(e => e.ScValId);

                entity.ToTable("T_S_CONT_VALEUR");

                entity.Property(e => e.ScValId)
                    .HasColumnName("SC_VAL_ID")
                    .HasComment("identifiant de la valeur percue d'une contravention");

                entity.Property(e => e.ScValDateDelai)
                    .HasColumnName("SC_VAL_DATE_DELAI")
                    .HasColumnType("date")
                    .HasComment("delai de paiement légal (au plus tard) de la contravention");

                entity.Property(e => e.ScValDateEmission)
                    .HasColumnName("SC_VAL_DATE_EMISSION")
                    .HasColumnType("date")
                    .HasComment("date d'émission de la contravention");

                entity.Property(e => e.ScValDatePaiement)
                    .HasColumnName("SC_VAL_DATE_PAIEMENT")
                    .HasColumnType("date")
                    .HasComment("date de paiement effective de la contravention");

                entity.Property(e => e.ScValDescription)
                    .HasColumnName("SC_VAL_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("diverses informations relatives à la contravention");

                entity.Property(e => e.ScValDescriptionVictime)
                    .HasColumnName("SC_VAL_DESCRIPTION_VICTIME")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ScValNomVictime)
                    .HasColumnName("SC_VAL_NOM_VICTIME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScValPrenomsVictime)
                    .HasColumnName("SC_VAL_PRENOMS_VICTIME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScValScContId)
                    .HasColumnName("SC_VAL_SC_CONT_ID")
                    .HasComment("identifiant de la contravention associée");

                entity.Property(e => e.ScValValeur)
                    .HasColumnName("SC_VAL_VALEUR")
                    .HasComment("valeur de la contravention payée");

                entity.Property(e => e.ScValZoneId)
                    .HasColumnName("SC_VAL_ZONE_ID")
                    .HasComment("identifiant de la zone géographique associée");

                entity.HasOne(d => d.ScValScCont)
                    .WithMany(p => p.TSContValeur)
                    .HasForeignKey(d => d.ScValScContId)
                    .HasConstraintName("FK_T_S_CONT_VALEUR_T_S_CONT_CONTRAVENTION");

                entity.HasOne(d => d.ScValZone)
                    .WithMany(p => p.TSContValeur)
                    .HasForeignKey(d => d.ScValZoneId)
                    .HasConstraintName("FK_T_S_CONT_VALEUR_T_ZONE");
            });

            modelBuilder.Entity<TSIncCategorie>(entity =>
            {
                entity.HasKey(e => e.SiCatId);

                entity.ToTable("T_S_INC_CATEGORIE");

                entity.Property(e => e.SiCatId)
                    .HasColumnName("SI_CAT_ID")
                    .HasComment("identifiant de la catégorie")
                    .ValueGeneratedNever();

                entity.Property(e => e.SiCatDesription)
                    .HasColumnName("SI_CAT_DESRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de la catégorie");

                entity.Property(e => e.SiCatLibelle)
                    .HasColumnName("SI_CAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la catégorie");

                entity.Property(e => e.SiCatSiRepId)
                    .HasColumnName("SI_CAT_SI_REP_ID")
                    .HasComment("identifiant de la représentation graphique associée");

                entity.Property(e => e.SiIncSiRepId)
                    .HasColumnName("SI_INC_SI_REP_ID")
                    .HasComment("identifiant de la représentation graphique associée");

                entity.HasOne(d => d.SiIncSiRep)
                    .WithMany(p => p.TSIncCategorie)
                    .HasForeignKey(d => d.SiIncSiRepId)
                    .HasConstraintName("FK_T_S_INC_CATEGORIE_T_S_INC_REPRESENTATION");
            });

            modelBuilder.Entity<TSIncIncident>(entity =>
            {
                entity.HasKey(e => e.SiIncId);

                entity.ToTable("T_S_INC_INCIDENT");

                entity.Property(e => e.SiIncId)
                    .HasColumnName("SI_INC_ID")
                    .HasComment("identifiant d'un incident");

                entity.Property(e => e.SiCatSiIncId).HasColumnName("SI_CAT_SI_INC_ID");

                entity.Property(e => e.SiIncDate)
                    .HasColumnName("SI_INC_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date de l'incident");

                entity.Property(e => e.SiIncDescripLieu)
                    .HasColumnName("SI_INC_DESCRIP_LIEU")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description du lieu où s'est produit l'incident");

                entity.Property(e => e.SiIncDescription)
                    .HasColumnName("SI_INC_DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("description de l'incident");

                entity.Property(e => e.SiIncLat)
                    .HasColumnName("SI_INC_LAT")
                    .HasComment("latitude, composante de la coordonnée du lieu ");

                entity.Property(e => e.SiIncLibelle)
                    .HasColumnName("SI_INC_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("libellé de l'incident");

                entity.Property(e => e.SiIncLon)
                    .HasColumnName("SI_INC_LON")
                    .HasComment("longitude, composante de la coordonnée du lieu ");

                entity.Property(e => e.SiIncWkid)
                    .HasColumnName("SI_INC_WKID")
                    .HasComment("entier compris par les serveur ARCGIS pour définir le référentiel des coordonnées définies");

                entity.Property(e => e.SiIncZoneCodeGeo)
                    .HasColumnName("SI_INC_ZONE_CODE_GEO")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("code géographique de la zone. Information pouvant être récupérée à partir de ZONE_ID mais le nom respect de la forme normale est faite dans un soucis d'optimisation des processus dans les algorithmes");

                entity.Property(e => e.SiIncZoneId)
                    .HasColumnName("SI_INC_ZONE_ID")
                    .HasComment("identifiant de la zone géographique concernée");

                entity.HasOne(d => d.SiCatSiInc)
                    .WithMany(p => p.TSIncIncident)
                    .HasForeignKey(d => d.SiCatSiIncId)
                    .HasConstraintName("FK_T_S_INC_INCIDENT_T_S_INC_CATEGORIE");

                entity.HasOne(d => d.SiIncZone)
                    .WithMany(p => p.TSIncIncident)
                    .HasForeignKey(d => d.SiIncZoneId)
                    .HasConstraintName("FK_T_S_INC_INCIDENT_T_ZONE");
            });

            modelBuilder.Entity<TSIncRepresentation>(entity =>
            {
                entity.HasKey(e => e.SiRepId);

                entity.ToTable("T_S_INC_REPRESENTATION");

                entity.Property(e => e.SiRepId)
                    .HasColumnName("SI_REP_ID")
                    .HasComment("identifiant de la représentation (image pouvant être affichée sur la carte)");

                entity.Property(e => e.SiRepCode)
                    .HasColumnName("SI_REP_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("le code de la représentation utilisé pour retrouver l'image dans le code source");

                entity.Property(e => e.SiRepDescription)
                    .HasColumnName("SI_REP_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("description de la représentation (ex: agression à main armée)");
            });

            modelBuilder.Entity<TSonPopulation>(entity =>
            {
                entity.HasKey(e => e.PopId);

                entity.ToTable("T_SON_POPULATION");

                entity.Property(e => e.PopId).HasColumnName("POP_ID");

                entity.Property(e => e.PopAge).HasColumnName("POP_AGE");

                entity.Property(e => e.PopProfId).HasColumnName("POP_PROF_ID");

                entity.Property(e => e.PopPseudo).HasColumnName("POP_PSEUDO");

                entity.Property(e => e.PopSexe)
                    .HasColumnName("POP_SEXE")
                    .HasMaxLength(10);

                entity.HasOne(d => d.PopProf)
                    .WithMany(p => p.TSonPopulation)
                    .HasForeignKey(d => d.PopProfId)
                    .HasConstraintName("FK_T_SON_POPULATION_T_SON_PROFESSION");
            });

            modelBuilder.Entity<TSonProfession>(entity =>
            {
                entity.HasKey(e => e.ProfId);

                entity.ToTable("T_SON_PROFESSION");

                entity.Property(e => e.ProfId).HasColumnName("PROF_ID");

                entity.Property(e => e.ProfLibelle)
                    .HasColumnName("PROF_LIBELLE")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TSonQuestion>(entity =>
            {
                entity.HasKey(e => e.QuesId);

                entity.ToTable("T_SON_QUESTION");

                entity.Property(e => e.QuesId).HasColumnName("QUES_ID");

                entity.Property(e => e.QuesLibelle)
                    .HasColumnName("QUES_LIBELLE")
                    .HasComment("Libelle de la question");

                entity.Property(e => e.QuesSondId).HasColumnName("QUES_SOND_ID");

                entity.HasOne(d => d.QuesSond)
                    .WithMany(p => p.TSonQuestion)
                    .HasForeignKey(d => d.QuesSondId)
                    .HasConstraintName("FK_T_SON_QUESTION_T_SON_SONDAGE");
            });

            modelBuilder.Entity<TSonSondage>(entity =>
            {
                entity.HasKey(e => e.SondId);

                entity.ToTable("T_SON_SONDAGE");

                entity.Property(e => e.SondId).HasColumnName("SOND_ID");

                entity.Property(e => e.SondDate)
                    .HasColumnName("SOND_DATE")
                    .HasColumnType("date")
                    .HasComment("La date à laquelle le sondage a été fait");

                entity.Property(e => e.SondLibelle)
                    .HasColumnName("SOND_LIBELLE")
                    .HasComment("Le libelle du sondage");
            });

            modelBuilder.Entity<TTempValeurUnused>(entity =>
            {
                entity.HasKey(e => e.ValZoneId);

                entity.ToTable("T_TEMP_VALEUR_UNUSED");

                entity.Property(e => e.ValZoneId)
                    .HasColumnName("VAL_ZONE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValMontant).HasColumnName("VAL_MONTANT");

                entity.Property(e => e.ValZoneLibelle)
                    .HasColumnName("VAL_ZONE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ValZoneLibelleComplet)
                    .HasColumnName("VAL_ZONE_LIBELLE_COMPLET")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTraces>(entity =>
            {
                entity.HasKey(e => e.TracId);

                entity.ToTable("T_Traces");

                entity.Property(e => e.TracId)
                    .HasColumnName("TRAC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgId)
                    .HasColumnName("AG_ID")
                    .HasComment("identifiant de l'utilisateur ayant effectué l'action");

                entity.Property(e => e.TracAction)
                    .HasColumnName("TRAC_Action")
                    .HasDefaultValueSql("((-1))")
                    .HasComment("1- création ; 2- modification ; 3- suppression");

                entity.Property(e => e.TracBConnexion)
                    .HasColumnName("TRAC_bConnexion")
                    .HasComment("indique si l'action est une connexion à l'application");

                entity.Property(e => e.TracBDeconnexion)
                    .HasColumnName("TRAC_bDeconnexion")
                    .HasComment("indique si l'action est une déconnexion à l'application");

                entity.Property(e => e.TracDate)
                    .HasColumnName("TRAC_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("date d'enregistrement de la trace");

                entity.Property(e => e.TracDescription)
                    .IsRequired()
                    .HasColumnName("TRAC_Description")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Description de l'action");

                entity.Property(e => e.TracObjet)
                    .IsRequired()
                    .HasColumnName("TRAC_Objet")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasComment("Nom de l'objet ayant subi l'action");

                entity.Property(e => e.TracObjetValeur)
                    .HasColumnName("TRAC_ObjetValeur")
                    .IsUnicode(false)
                    .HasComment("les valeurs manipulées par l'action");

                entity.HasOne(d => d.Ag)
                    .WithMany(p => p.TTraces)
                    .HasForeignKey(d => d.AgId)
                    .HasConstraintName("FK_T_Traces_T_Agent");
            });

            modelBuilder.Entity<TTypePiece>(entity =>
            {
                entity.HasKey(e => e.TpId);

                entity.ToTable("T_TYPE_PIECE");

                entity.Property(e => e.TpId)
                    .HasColumnName("TP_ID")
                    .HasComment("libellé du type de pièce");

                entity.Property(e => e.PieceCode)
                    .HasColumnName("PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TpLibelle)
                    .HasColumnName("TP_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVActiviteAnalyseNationalite>(entity =>
            {
                entity.HasKey(e => e.ActpaId);

                entity.ToTable("T_V_ACTIVITE_ANALYSE_NATIONALITE");

                entity.Property(e => e.ActpaId).HasColumnName("ACTPA_ID");

                entity.Property(e => e.ActpaActId).HasColumnName("ACTPA_ACT_ID");

                entity.Property(e => e.ActpaDate)
                    .HasColumnName("ACTPA_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ActpaMontant).HasColumnName("ACTPA_MONTANT");

                entity.Property(e => e.ActpaNatId).HasColumnName("ACTPA_NAT_ID");

                entity.Property(e => e.ActpaNombre).HasColumnName("ACTPA_NOMBRE");

                entity.Property(e => e.ActpaQuartierId).HasColumnName("ACTPA_QUARTIER_ID");

                entity.Property(e => e.ActpaQuartierLibelle)
                    .HasColumnName("ACTPA_QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActpaTaxfId).HasColumnName("ACTPA_TAXF_ID");

                entity.Property(e => e.ActpaTaxfLiblelle)
                    .HasColumnName("ACTPA_TAXF_LIBLELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVRecouvrementCarte>(entity =>
            {
                entity.ToTable("T_V_RECOUVREMENT_CARTE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActcontActId).HasColumnName("ACTCONT_ACT_ID");

                entity.Property(e => e.ActcontPlaqueOld)
                    .HasColumnName("ACTCONT_PLAQUE_OLD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MontantImpaye).HasColumnName("MONTANT_IMPAYE");

                entity.Property(e => e.NombreImpaye).HasColumnName("NOMBRE_IMPAYE");

                entity.Property(e => e.NumCntig)
                    .HasColumnName("NUM_CNTIG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxTaxfId).HasColumnName("TAX_TAXF_ID");

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneSecId).HasColumnName("ZONE_SEC_ID");
            });

            modelBuilder.Entity<TVResCollecteRealisee>(entity =>
            {
                entity.HasKey(e => e.ColId);

                entity.ToTable("T_V_RES_COLLECTE_REALISEE");

                entity.Property(e => e.ColId)
                    .HasColumnName("COL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcolId).HasColumnName("ACOL_ID");

                entity.Property(e => e.AcolMatricule)
                    .HasColumnName("ACOL_MATRICULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColBExportPaiement).HasColumnName("COL_bEXPORT_PAIEMENT");

                entity.Property(e => e.ColDate)
                    .HasColumnName("COL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ColMontant).HasColumnName("COL_MONTANT");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactCode)
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasColumnName("ZONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<TVResFacture>(entity =>
            {
                entity.HasKey(e => e.FactCode);

                entity.ToTable("T_V_RES_FACTURE");

                entity.Property(e => e.FactCode)
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.ActcontNom)
                    .HasColumnName("ACTCONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontRefId).HasColumnName("ACTCONT_REF_ID");

                entity.Property(e => e.ActcontZoneId).HasColumnName("ACTCONT_ZONE_ID");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContId).HasColumnName("CONT_ID");

                entity.Property(e => e.ContNcc)
                    .HasColumnName("CONT_NCC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpteCode)
                    .HasColumnName("CPTE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpteLibelle)
                    .HasColumnName("CPTE_LIBELLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacPotentiel).HasColumnName("FAC_POTENTIEL");

                entity.Property(e => e.FactBEtatReglement).HasColumnName("FACT_bETAT_REGLEMENT");

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnName("TAX_ID");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaxactId).HasColumnName("TAXACT_ID");
            });

            modelBuilder.Entity<TVResFactureDashboard>(entity =>
            {
                entity.HasKey(e => e.DqtId);

                entity.ToTable("T_V_RES_FACTURE_DASHBOARD");

                entity.Property(e => e.DqtId).HasColumnName("DQT_ID");

                entity.Property(e => e.DqtBEtatReglement).HasColumnName("DQT_bETAT_REGLEMENT");

                entity.Property(e => e.DqtCommuneId).HasColumnName("DQT_COMMUNE_ID");

                entity.Property(e => e.DqtCommuneLibelle)
                    .HasColumnName("DQT_COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DqtDate)
                    .HasColumnName("DQT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.DqtMontant).HasColumnName("DQT_MONTANT");

                entity.Property(e => e.DqtNombre).HasColumnName("DQT_NOMBRE");

                entity.Property(e => e.DqtPotentiel).HasColumnName("DQT_POTENTIEL");

                entity.Property(e => e.DqtQuartierId).HasColumnName("DQT_QUARTIER_ID");

                entity.Property(e => e.DqtQuartierLibelle)
                    .HasColumnName("DQT_QUARTIER_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DqtTaxfId).HasColumnName("DQT_TAXF_ID");

                entity.Property(e => e.DqtTaxfLibelle)
                    .HasColumnName("DQT_TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TVResFactureSoldee>(entity =>
            {
                entity.HasKey(e => e.FactCode);

                entity.ToTable("T_V_RES_FACTURE_SOLDEE");

                entity.Property(e => e.FactCode)
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActId)
                    .HasColumnName("ACT_ID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.CpteCode).HasColumnName("CPTE_CODE");

                entity.Property(e => e.CpteLibelle)
                    .HasColumnName("CPTE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaieId).HasColumnName("PAIE_ID");

                entity.Property(e => e.TaxId).HasColumnName("TAX_ID");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxactId).HasColumnName("TAXACT_ID");
            });

            modelBuilder.Entity<TVResRecette>(entity =>
            {
                entity.HasKey(e => e.PaieId);

                entity.ToTable("T_V_RES_RECETTE");

                entity.Property(e => e.PaieId)
                    .HasColumnName("PAIE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactCode)
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaieMontant).HasColumnName("PAIE_MONTANT");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ScContLibelle)
                    .HasColumnName("SC_CONT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasColumnName("ZONE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<TVZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId);

                entity.ToTable("T_V_ZONE");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZONE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoCommune)
                    .HasColumnName("COD_GEO_COMMUNE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoIlot)
                    .HasColumnName("COD_GEO_ILOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoLot)
                    .HasColumnName("COD_GEO_LOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoQuartier)
                    .HasColumnName("COD_GEO_QUARTIER")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.NumCntigCommune)
                    .HasColumnName("NUM_CNTIG_COMMUNE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigIlo)
                    .HasColumnName("NUM_CNTIG_ILO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigLot)
                    .HasColumnName("NUM_CNTIG_LOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigQuartier)
                    .HasColumnName("NUM_CNTIG_QUARTIER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TValeurIndicateurZone>(entity =>
            {
                entity.HasKey(e => e.ValId);

                entity.ToTable("T_Valeur_Indicateur_Zone");

                entity.Property(e => e.ValId)
                    .HasColumnName("VAL_ID")
                    .HasComment("Identifiant de la valeur de l'indicateur");

                entity.Property(e => e.IndCode)
                    .HasColumnName("IND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Identifiant de l'indicateur concerné");

                entity.Property(e => e.ValDate)
                    .HasColumnName("VAL_Date")
                    .HasColumnType("date")
                    .HasComment("Date associée à la valeur");

                entity.Property(e => e.ValValeurAlpha)
                    .HasColumnName("VAL_ValeurAlpha")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("Valeur alpha numérique associée à l'indicateur et la zone concernée");

                entity.Property(e => e.ValValeurNumerique)
                    .HasColumnName("VAL_ValeurNumerique")
                    .HasComment("Valeur numérique associée à l'indicateur pour la zone conernée");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZONE_ID")
                    .HasComment("Identifiant de la zone géographique concernée");

                entity.HasOne(d => d.IndCodeNavigation)
                    .WithMany(p => p.TValeurIndicateurZone)
                    .HasForeignKey(d => d.IndCode)
                    .HasConstraintName("FK_T_Valeur_Indicateur_Zone_T_Indicateur");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.TValeurIndicateurZone)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_T_Valeur_Indicateur_Zone_T_ZONE");
            });

            modelBuilder.Entity<TZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId);

                entity.ToTable("T_ZONE");

                entity.HasIndex(e => e.ZoneId)
                    .HasName("IX_T_ZONE");

                entity.Property(e => e.ZoneId)
                    .HasColumnName("ZONE_ID")
                    .HasComment("Identifiant de l'élément");

                entity.Property(e => e.BDelete).HasColumnName("bDelete");

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComment("code geographique utilisé pour faire le rapprochement avec la couche d'information géographique");

                entity.Property(e => e.CodGeoParent)
                    .HasColumnName("COD_GEO_PARENT")
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("Description de la zone concernée");

                entity.Property(e => e.IdCat)
                    .HasColumnName("ID_CAT")
                    .HasComment("identifiant de la catégorie associée");

                entity.Property(e => e.IdZoneParent)
                    .HasColumnName("ID_ZONE_PARENT")
                    .HasComment("identifiant de la zone parent");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la zone concernée");

                entity.Property(e => e.NumCntig)
                    .HasColumnName("NUM_CNTIG")
                    .HasDefaultValueSql("((0))")
                    .HasComment("numéro attribué par le CNTIG à un lot spécifique");

                entity.Property(e => e.SpgeGpsLat)
                    .HasColumnName("SPGE_GPS_LAT")
                    .HasComment("lattitude de la zone concernée (ou de son centre)");

                entity.Property(e => e.SpgeGpsLon)
                    .HasColumnName("SPGE_GPS_LON")
                    .HasComment("longitude de la zone concernée (ou de son centre)");

                entity.Property(e => e.SpgeRepere)
                    .HasColumnName("SPGE_REPERE")
                    .HasComment("Repère associée aux coordonnées longitude, latitude associées à la zone");

                entity.Property(e => e.ZoneSecId)
                    .HasColumnName("ZONE_SEC_ID")
                    .HasComment("identifiant de la SECTEUR - ZONE COMMUNE (ensemble de quartier) auquel appartient la zone courante");

                entity.HasOne(d => d.IdCatNavigation)
                    .WithMany(p => p.TZone)
                    .HasForeignKey(d => d.IdCat)
                    .HasConstraintName("FK_T_ZONE_T_ZONE_CATEGORIE");

                entity.HasOne(d => d.IdZoneParentNavigation)
                    .WithMany(p => p.InverseIdZoneParentNavigation)
                    .HasForeignKey(d => d.IdZoneParent)
                    .HasConstraintName("FK_T_ZONE_T_ZONE");

                entity.HasOne(d => d.ZoneSec)
                    .WithMany(p => p.TZone)
                    .HasForeignKey(d => d.ZoneSecId)
                    .HasConstraintName("FK_T_ZONE_T_ZONE_SECTEUR");
            });

            modelBuilder.Entity<TZoneCaracteristique>(entity =>
            {
                entity.HasKey(e => e.ZcId);

                entity.ToTable("T_ZONE_CARACTERISTIQUE");

                entity.Property(e => e.ZcId)
                    .HasColumnName("ZC_ID")
                    .HasComment("identifiant d'une caractéristique de zone géographique (ex: bitume, avenue, préseau eau, presence villa, presence batiment, appartenance à une opération immobiliere)");

                entity.Property(e => e.ZcDescription)
                    .HasColumnName("ZC_DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("description de la caractéristique");

                entity.Property(e => e.ZcLibelle)
                    .HasColumnName("ZC_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libelle de la caractéristique");
            });

            modelBuilder.Entity<TZoneCaracteristiquePresence>(entity =>
            {
                entity.HasKey(e => e.ZcpId);

                entity.ToTable("T_ZONE_CARACTERISTIQUE_PRESENCE");

                entity.Property(e => e.ZcpId)
                    .HasColumnName("ZCP_ID")
                    .HasComment("id de la relation entre zone et zoneCaracteristique");

                entity.Property(e => e.ZcpCommentaire)
                    .HasColumnName("ZCP_COMMENTAIRE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("éventuel commentaire");

                entity.Property(e => e.ZcpZcId)
                    .HasColumnName("ZCP_ZC_ID")
                    .HasComment("identifiant de la caractérisitque");

                entity.Property(e => e.ZcpZoneId)
                    .HasColumnName("ZCP_ZONE_ID")
                    .HasComment("identifiant de la zone");

                entity.HasOne(d => d.ZcpZc)
                    .WithMany(p => p.TZoneCaracteristiquePresence)
                    .HasForeignKey(d => d.ZcpZcId)
                    .HasConstraintName("FK_T_ZONE_CARACTERISTIQUE_PRESENCE_T_ZONE_CARACTERISTIQUE");

                entity.HasOne(d => d.ZcpZone)
                    .WithMany(p => p.TZoneCaracteristiquePresence)
                    .HasForeignKey(d => d.ZcpZoneId)
                    .HasConstraintName("FK_T_ZONE_CARACTERISTIQUE_PRESENCE_T_ZONE");
            });

            modelBuilder.Entity<TZoneCategorie>(entity =>
            {
                entity.HasKey(e => e.IdCat)
                    .HasName("PK_T_Type");

                entity.ToTable("T_ZONE_CATEGORIE");

                entity.Property(e => e.IdCat)
                    .HasColumnName("ID_CAT")
                    .HasComment("Identifiant de la catégorie");

                entity.Property(e => e.CatZoneEstActif)
                    .HasColumnName("CAT_ZONE_EstACTIF")
                    .HasComment("Vrai indique que la catégorie de zone est exploitable dans l'application");

                entity.Property(e => e.CatZoneEstParcelleSectionAutre)
                    .HasColumnName("CAT_ZONE_EST_parcelle_section_autre")
                    .HasDefaultValueSql("((0))")
                    .HasComment("2: est parcelle /lot ; 1: est section  /ilot; 0: est AUTRE");

                entity.Property(e => e.CatZoneOrdre)
                    .HasColumnName("CAT_ZONE_ORDRE")
                    .HasComment("Ordre de la catégorie dans le type de zone (ex: ordre de la catégorie REGION dans le découpage administratif)");

                entity.Property(e => e.CodParent)
                    .HasColumnName("COD_PARENT")
                    .HasComment("identifiant de la catégorie parente associée (ex: CODE DE CATEGORIE DISTRICT pour REGION)");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false)
                    .HasComment("Description de la catégorie");

                entity.Property(e => e.IdTypezone)
                    .HasColumnName("ID_TYPEZONE")
                    .HasComment("identifiant du type de découpage (ex: code de DECOUPAGE ADMINISTRATIF)");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("Libellé de la catégorie");

                entity.Property(e => e.UrlCouche)
                    .HasColumnName("url_couche")
                    .IsUnicode(false)
                    .HasComment("URL de la couche géographique associée à la catégorie indexée");

                entity.HasOne(d => d.IdTypezoneNavigation)
                    .WithMany(p => p.TZoneCategorie)
                    .HasForeignKey(d => d.IdTypezone)
                    .HasConstraintName("FK_T_ZONE_CATEGORIE_T_ZONE_TYPE");
            });

            modelBuilder.Entity<TZonePropriete>(entity =>
            {
                entity.HasKey(e => e.ProzId);

                entity.ToTable("T_ZONE_PROPRIETE");

                entity.Property(e => e.ProzId)
                    .HasColumnName("PROZ_ID")
                    .HasComment("identifiant de la table");

                entity.Property(e => e.ProzDescription)
                    .HasColumnName("PROZ_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("description de la propriété");

                entity.Property(e => e.ProzLibelle)
                    .HasColumnName("PROZ_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé de la propriété sur zone (présence eau, bati, ...)");
            });

            modelBuilder.Entity<TZoneSecteur>(entity =>
            {
                entity.HasKey(e => e.SecId)
                    .HasName("PK_T_ZONE_COMMUNE");

                entity.ToTable("T_ZONE_SECTEUR");

                entity.Property(e => e.SecId)
                    .HasColumnName("SEC_ID")
                    .HasComment("identifiant de la table ZONE COMMUNE");

                entity.Property(e => e.SecDescription)
                    .HasColumnName("SEC_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasComment("description de la zone commune");

                entity.Property(e => e.SecLibelle)
                    .HasColumnName("SEC_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé associé à l'ensemble de quartier concerné par l'enregistrement");
            });

            modelBuilder.Entity<TZoneType>(entity =>
            {
                entity.HasKey(e => e.IdTypezone);

                entity.ToTable("T_ZONE_TYPE");

                entity.Property(e => e.IdTypezone)
                    .HasColumnName("ID_TYPEZONE")
                    .HasComment("identifiant du type de découpage")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypezoneBEstActif)
                    .HasColumnName("TYPEZONE_bEstActif")
                    .HasComment("indique que la catégorie de zone géographique est utilisée dans l'application");

                entity.Property(e => e.TypezoneDescription)
                    .HasColumnName("TYPEZONE_DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("description du découpage");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("libellé du découpage");
            });

            modelBuilder.Entity<TZoneinfoZonepropriete>(entity =>
            {
                entity.HasKey(e => e.ZiprozId);

                entity.ToTable("T_ZONEINFO_ZONEPROPRIETE");

                entity.Property(e => e.ZiprozId)
                    .HasColumnName("ZIPROZ_ID")
                    .HasComment("identifiant de la table de relation");

                entity.Property(e => e.ZiprozBooleen)
                    .HasColumnName("ZIPROZ_BOOLEEN")
                    .HasComment("valeur bouléenne associée à la propriété");

                entity.Property(e => e.ZiprozDate)
                    .HasColumnName("ZIPROZ_DATE")
                    .HasColumnType("datetime")
                    .HasComment("date associée à la propriété");

                entity.Property(e => e.ZiprozEntier)
                    .HasColumnName("ZIPROZ_ENTIER")
                    .HasComment("valeur entière associée à la propriété");

                entity.Property(e => e.ZiprozProzId)
                    .HasColumnName("ZIPROZ_PROZ_ID")
                    .HasComment("identifiant de la propriété de zone");

                entity.Property(e => e.ZiprozValeur)
                    .HasColumnName("ZIPROZ_VALEUR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("valeur renseignée");

                entity.Property(e => e.ZiprozZiId)
                    .HasColumnName("ZIPROZ_ZI_ID")
                    .HasComment("identifiant de la zone zone d'information");

                entity.HasOne(d => d.ZiprozProz)
                    .WithMany(p => p.TZoneinfoZonepropriete)
                    .HasForeignKey(d => d.ZiprozProzId)
                    .HasConstraintName("FK_T_ZONEINFO_ZONEPROPRIETE_T_ZONE_PROPRIETE");

                entity.HasOne(d => d.ZiprozZi)
                    .WithMany(p => p.TZoneinfoZonepropriete)
                    .HasForeignKey(d => d.ZiprozZiId)
                    .HasConstraintName("FK_T_ZONEINFO_ZONEPROPRIETE_T_C_ZONE_INFOS");
            });

            modelBuilder.Entity<TempActiviteLot>(entity =>
            {
                entity.ToTable("TEMP_ACTIVITE_LOT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TmbIdActivite).HasColumnName("TMB_idActivite");

                entity.Property(e => e.TmbNumCntig).HasColumnName("TMB_NUM_CNTIG");

                entity.Property(e => e.TmpArticleActivite)
                    .HasColumnName("TMP_ARTICLE_ACTIVITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpBUsed).HasColumnName("TMP_bUSED");

                entity.Property(e => e.TmpCodeActivite)
                    .HasColumnName("TMP_CODE_ACTIVITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpCommuneLibelle)
                    .HasColumnName("TMP_COMMUNE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpDateOccupAn).HasColumnName("TMP_DATE_OCCUP_AN");

                entity.Property(e => e.TmpDateOccupAnnee).HasColumnName("TMP_DATE_OCCUP_ANNEE");

                entity.Property(e => e.TmpDateOccupJour).HasColumnName("TMP_DATE_OCCUP_JOUR");

                entity.Property(e => e.TmpDateOccupMois).HasColumnName("TMP_DATE_OCCUP_MOIS");

                entity.Property(e => e.TmpEnseigneLibelle)
                    .HasColumnName("TMP_ENSEIGNE_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TmpEnseigneType)
                    .HasColumnName("TMP_ENSEIGNE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpGenre)
                    .HasColumnName("TMP_GENRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpIlot)
                    .HasColumnName("TMP_ILOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpLot)
                    .HasColumnName("TMP_LOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpNationalite)
                    .HasColumnName("TMP_NATIONALITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpNomPrenom)
                    .HasColumnName("TMP_NOM_PRENOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TmpNumCntig).HasColumnName("TMP_NUM_CNTIG");

                entity.Property(e => e.TmpNumFiche).HasColumnName("TMP_NUM_FICHE");

                entity.Property(e => e.TmpNumMairie)
                    .HasColumnName("TMP_NUM_MAIRIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPieceNature)
                    .HasColumnName("TMP_PIECE_NATURE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpPieceNumero)
                    .HasColumnName("TMP_PIECE_NUMERO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpQuartierLibelle)
                    .HasColumnName("TMP_QUARTIER_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre1)
                    .HasColumnName("TMP_TAXE_AUTRE_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre1Montant).HasColumnName("TMP_TAXE_AUTRE_1_MONTANT");

                entity.Property(e => e.TmpTaxeAutre1Periodicite)
                    .HasColumnName("TMP_TAXE_AUTRE_1_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre2)
                    .HasColumnName("TMP_TAXE_AUTRE_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre2Montant).HasColumnName("TMP_TAXE_AUTRE_2_MONTANT");

                entity.Property(e => e.TmpTaxeAutre2Periodicite)
                    .HasColumnName("TMP_TAXE_AUTRE_2_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre3)
                    .HasColumnName("TMP_TAXE_AUTRE_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeAutre3Montant).HasColumnName("TMP_TAXE_AUTRE_3_MONTANT");

                entity.Property(e => e.TmpTaxeAutre3Periodicite)
                    .HasColumnName("TMP_TAXE_AUTRE_3_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TmpTaxeJourMontant).HasColumnName("TMP_TAXE_JOUR_MONTANT");
            });

            modelBuilder.Entity<TempActiviteTaxeOfficiel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_ACTIVITE_TAXE_OFFICIEL");

                entity.Property(e => e.Code)
                    .HasColumnName("CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxeMensuelle)
                    .HasColumnName("TAXE MENSUELLE")
                    .HasMaxLength(255);

                entity.Property(e => e.TaxeMensuelleMoyenne)
                    .HasColumnName("TAXE MENSUELLE MOYENNE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TempMarche>(entity =>
            {
                entity.HasKey(e => e.TempId);

                entity.ToTable("TEMP_MARCHE");

                entity.Property(e => e.TempId).HasColumnName("TEMP_ID");

                entity.Property(e => e.TempArticleVendu)
                    .HasColumnName("TEMP_ARTICLE_VENDU")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempBUsed).HasColumnName("TEMP_bUSED");

                entity.Property(e => e.TempCntig).HasColumnName("TEMP_CNTIG");

                entity.Property(e => e.TempCodeActivite)
                    .HasColumnName("TEMP_CODE_ACTIVITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempCommune)
                    .HasColumnName("TEMP_COMMUNE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempEnqueteAnnee).HasColumnName("TEMP_ENQUETE_ANNEE");

                entity.Property(e => e.TempEnqueteDate)
                    .HasColumnName("TEMP_ENQUETE_DATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempEnqueteJour).HasColumnName("TEMP_ENQUETE_JOUR");

                entity.Property(e => e.TempEnqueteMois).HasColumnName("TEMP_ENQUETE_MOIS");

                entity.Property(e => e.TempEnqueteurEquipe)
                    .HasColumnName("TEMP_ENQUETEUR_EQUIPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempEnqueteurNom)
                    .HasColumnName("TEMP_ENQUETEUR_NOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempEnseigneLibelle)
                    .HasColumnName("TEMP_ENSEIGNE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempEnseigneType)
                    .HasColumnName("TEMP_ENSEIGNE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempIdActivite).HasColumnName("TEMP_idActivite");

                entity.Property(e => e.TempIlot)
                    .HasColumnName("TEMP_ILOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempLot)
                    .HasColumnName("TEMP_LOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempMarche1)
                    .HasColumnName("TEMP_MARCHE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempMerge)
                    .HasColumnName("TEMP_MERGE")
                    .HasMaxLength(50);

                entity.Property(e => e.TempNiveau).HasColumnName("TEMP_NIVEAU");

                entity.Property(e => e.TempNumeroCntig)
                    .HasColumnName("TEMP_NUMERO_CNTIG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempNumeroFiche).HasColumnName("TEMP_NUMERO_FICHE");

                entity.Property(e => e.TempNumeroMairie)
                    .HasColumnName("TEMP_NUMERO_MAIRIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempNumeroRangee)
                    .HasColumnName("TEMP_NUMERO_RANGEE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempOccupationAnnee).HasColumnName("TEMP_OCCUPATION_ANNEE");

                entity.Property(e => e.TempOccupationDate).HasColumnName("TEMP_OCCUPATION_DATE");

                entity.Property(e => e.TempOccupationJour).HasColumnName("TEMP_OCCUPATION_JOUR");

                entity.Property(e => e.TempOccupationMois).HasColumnName("TEMP_OCCUPATION_MOIS");

                entity.Property(e => e.TempProprietaireGenre)
                    .HasColumnName("TEMP_PROPRIETAIRE_GENRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempProprietaireNationalite)
                    .HasColumnName("TEMP_PROPRIETAIRE_NATIONALITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempProprietaireNom)
                    .HasColumnName("TEMP_PROPRIETAIRE_NOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempProprietairePieceNature)
                    .HasColumnName("TEMP_PROPRIETAIRE_PIECE_NATURE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempProprietairePieceNumero)
                    .HasColumnName("TEMP_PROPRIETAIRE_PIECE_NUMERO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempQuartier)
                    .HasColumnName("TEMP_QUARTIER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempStatut)
                    .HasColumnName("TEMP_STATUT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTableProprietaireGenre)
                    .HasColumnName("TEMP_TABLE_PROPRIETAIRE_GENRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTableProprietaireNationalite)
                    .HasColumnName("TEMP_TABLE_PROPRIETAIRE_NATIONALITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTableProprietaireNaturePiece)
                    .HasColumnName("TEMP_TABLE_PROPRIETAIRE_NATURE_PIECE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTableProprietaireNom)
                    .HasColumnName("TEMP_TABLE_PROPRIETAIRE_NOM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TempTableProprietaireNumeroPiece)
                    .HasColumnName("TEMP_TABLE_PROPRIETAIRE_NUMERO_PIECE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre1Libelle)
                    .HasColumnName("TEMP_TAXE_AUTRE_1_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre1Montant).HasColumnName("TEMP_TAXE_AUTRE_1_MONTANT");

                entity.Property(e => e.TempTaxeAutre1Periodicite)
                    .HasColumnName("TEMP_TAXE_AUTRE_1_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre2Libelle)
                    .HasColumnName("TEMP_TAXE_AUTRE_2_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre2Montant).HasColumnName("TEMP_TAXE_AUTRE_2_MONTANT");

                entity.Property(e => e.TempTaxeAutre2Periodicite)
                    .HasColumnName("TEMP_TAXE_AUTRE_2_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre3Libelle)
                    .HasColumnName("TEMP_TAXE_AUTRE_3_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeAutre3Montant).HasColumnName("TEMP_TAXE_AUTRE_3_MONTANT");

                entity.Property(e => e.TempTaxeAutre3Periodicite)
                    .HasColumnName("TEMP_TAXE_AUTRE_3_PERIODICITE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempTaxeJourMontant).HasColumnName("TEMP_TAXE_JOUR_MONTANT");
            });

            modelBuilder.Entity<TempParcelaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_PARCELAIRE");

                entity.Property(e => e.AdrMoral)
                    .HasColumnName("Adr_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.AdrOqpt)
                    .HasColumnName("Adr_oqpt")
                    .HasMaxLength(255);

                entity.Property(e => e.AdrPropr)
                    .HasColumnName("Adr_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.AvBitum)
                    .HasColumnName("Av_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.Avenue).HasMaxLength(255);

                entity.Property(e => e.Bld).HasMaxLength(255);

                entity.Property(e => e.BldBitum)
                    .HasColumnName("Bld_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.CmptEau)
                    .HasColumnName("Cmpt_eau")
                    .HasMaxLength(255);

                entity.Property(e => e.CmptElect)
                    .HasColumnName("Cmpt_elect")
                    .HasMaxLength(255);

                entity.Property(e => e.Cntig).HasMaxLength(50);

                entity.Property(e => e.Commerce).HasMaxLength(255);

                entity.Property(e => e.Commune).HasMaxLength(255);

                entity.Property(e => e.CourComm)
                    .HasColumnName("Cour_comm")
                    .HasMaxLength(255);

                entity.Property(e => e.DateFinT)
                    .HasColumnName("Date_fin_t")
                    .HasMaxLength(255);

                entity.Property(e => e.DateObt)
                    .HasColumnName("Date_obt")
                    .HasMaxLength(255);

                entity.Property(e => e.DatePass)
                    .HasColumnName("Date_pass")
                    .HasMaxLength(255);

                entity.Property(e => e.DatePerm)
                    .HasColumnName("Date_perm")
                    .HasMaxLength(255);

                entity.Property(e => e.Duplex).HasMaxLength(255);

                entity.Property(e => e.Eau).HasMaxLength(255);

                entity.Property(e => e.EdifRelig)
                    .HasColumnName("Edif_relig")
                    .HasMaxLength(255);

                entity.Property(e => e.Elect).HasMaxLength(255);

                entity.Property(e => e.Enqueteur).HasMaxLength(255);

                entity.Property(e => e.Enquêté).HasMaxLength(255);

                entity.Property(e => e.Entrepot).HasMaxLength(255);

                entity.Property(e => e.Entrp).HasMaxLength(255);

                entity.Property(e => e.EtabAdmi)
                    .HasColumnName("Etab_admi")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabCult)
                    .HasColumnName("Etab_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabSanit)
                    .HasColumnName("Etab_sanit")
                    .HasMaxLength(255);

                entity.Property(e => e.EtabScol)
                    .HasColumnName("Etab_scol")
                    .HasMaxLength(255);

                entity.Property(e => e.EtatVrie)
                    .HasColumnName("Etat_vrie")
                    .HasMaxLength(255);

                entity.Property(e => e.FrBornage)
                    .HasColumnName("Fr_bornage")
                    .HasMaxLength(255);

                entity.Property(e => e.HabitComm)
                    .HasColumnName("Habit_comm")
                    .HasMaxLength(255);

                entity.Property(e => e.Habitat)
                    .HasColumnName("Habitat°")
                    .HasMaxLength(255);

                entity.Property(e => e.Hangar).HasMaxLength(255);

                entity.Property(e => e.HtatPrec)
                    .HasColumnName("Htat°_prec")
                    .HasMaxLength(255);

                entity.Property(e => e.Ilot).HasMaxLength(50);

                entity.Property(e => e.Immeuble).HasMaxLength(255);

                entity.Property(e => e.Indus).HasMaxLength(255);

                entity.Property(e => e.LCult)
                    .HasColumnName("L_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.Lot).HasMaxLength(50);

                entity.Property(e => e.Magasin).HasMaxLength(255);

                entity.Property(e => e.MaisonBde)
                    .HasColumnName("Maison_bde")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat1)
                    .HasColumnName("N_etg_bat1")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat2)
                    .HasColumnName("N_etg_bat2")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat3)
                    .HasColumnName("N_etg_bat3")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat4)
                    .HasColumnName("N_etg_bat4")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat5)
                    .HasColumnName("N_etg_bat5")
                    .HasMaxLength(255);

                entity.Property(e => e.NEtgBat6)
                    .HasColumnName("N_etg_bat6")
                    .HasMaxLength(255);

                entity.Property(e => e.NLtrAttr)
                    .HasColumnName("N°ltr_attr")
                    .HasMaxLength(255);

                entity.Property(e => e.NatPropr)
                    .HasColumnName("Nat_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.NatureLot)
                    .HasColumnName("Nature_lot")
                    .HasMaxLength(255);

                entity.Property(e => e.NbrBat)
                    .HasColumnName("Nbr_bat")
                    .HasMaxLength(255);

                entity.Property(e => e.NbrBouche)
                    .HasColumnName("Nbr_bouche")
                    .HasMaxLength(255);

                entity.Property(e => e.NoRegCom)
                    .HasColumnName("No_reg_com")
                    .HasMaxLength(255);

                entity.Property(e => e.NomOqpant)
                    .HasColumnName("Nom_oqpant")
                    .HasMaxLength(255);

                entity.Property(e => e.NomPropr)
                    .HasColumnName("Nom_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.ObsEnq)
                    .HasColumnName("Obs_enq")
                    .HasMaxLength(255);

                entity.Property(e => e.OperatIm)
                    .HasColumnName("Operat°_im")
                    .HasMaxLength(255);

                entity.Property(e => e.OqptLocat)
                    .HasColumnName("Oqpt_locat")
                    .HasMaxLength(255);

                entity.Property(e => e.PermConst)
                    .HasColumnName("Perm_const")
                    .HasMaxLength(255);

                entity.Property(e => e.PersMoral)
                    .HasColumnName("Pers_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecAdmi)
                    .HasColumnName("Prec_admi")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecCult)
                    .HasColumnName("Prec_cult")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecEntrp)
                    .HasColumnName("Prec_entrp")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecHc)
                    .HasColumnName("Prec_hc")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecIndus)
                    .HasColumnName("Prec_indus")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecLcult)
                    .HasColumnName("Prec_Lcult")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSanit)
                    .HasColumnName("Prec_sanit")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecScol)
                    .HasColumnName("Prec_scol")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSecur)
                    .HasColumnName("Prec_secur")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecSprt)
                    .HasColumnName("Prec_sprt")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecTpCm)
                    .HasColumnName("Prec_tp_cm")
                    .HasMaxLength(255);

                entity.Property(e => e.PrecTrans)
                    .HasColumnName("Prec_trans")
                    .HasMaxLength(255);

                entity.Property(e => e.ProfPropr)
                    .HasColumnName("Prof_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.Promoteur).HasMaxLength(255);

                entity.Property(e => e.ProprPhys)
                    .HasColumnName("Propr_phys")
                    .HasMaxLength(255);

                entity.Property(e => e.PrénOqpan)
                    .HasColumnName("Prén_oqpan")
                    .HasMaxLength(255);

                entity.Property(e => e.PrénPropr)
                    .HasColumnName("Prén_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.Quartiers).HasMaxLength(255);

                entity.Property(e => e.RaisonSoc)
                    .HasColumnName("Raison_soc")
                    .HasMaxLength(255);

                entity.Property(e => e.ResidProp)
                    .HasColumnName("Resid_prop")
                    .HasMaxLength(255);

                entity.Property(e => e.Rue).HasMaxLength(255);

                entity.Property(e => e.RueBitum)
                    .HasColumnName("Rue_bitum")
                    .HasMaxLength(255);

                entity.Property(e => e.Securité).HasMaxLength(255);

                entity.Property(e => e.SiStaEss)
                    .HasColumnName("Si_sta_ess")
                    .HasMaxLength(255);

                entity.Property(e => e.Sprt).HasMaxLength(255);

                entity.Property(e => e.StatEss)
                    .HasColumnName("Stat°_ess")
                    .HasMaxLength(255);

                entity.Property(e => e.Superficie).HasMaxLength(255);

                entity.Property(e => e.Supervis).HasMaxLength(255);

                entity.Property(e => e.TelMoral)
                    .HasColumnName("Tel_moral")
                    .HasMaxLength(255);

                entity.Property(e => e.TelOqpt)
                    .HasColumnName("Tel_oqpt")
                    .HasMaxLength(255);

                entity.Property(e => e.TelPropr)
                    .HasColumnName("Tel_propr")
                    .HasMaxLength(255);

                entity.Property(e => e.Tf)
                    .HasColumnName("TF")
                    .HasMaxLength(255);

                entity.Property(e => e.Trans).HasMaxLength(255);

                entity.Property(e => e.Unité).HasMaxLength(255);

                entity.Property(e => e.Villa).HasMaxLength(255);
            });

            modelBuilder.Entity<TempPotentiel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMP_POTENTIEL");

                entity.Property(e => e.Idactivte).HasColumnName("IDACTIVTE");

                entity.Property(e => e.Potentiel).HasColumnName("POTENTIEL");

                entity.Property(e => e.PotentielAutre).HasColumnName("POTENTIEL_AUTRE");

                entity.Property(e => e.PotentielJr).HasColumnName("POTENTIEL_JR");
            });

            modelBuilder.Entity<TempZone>(entity =>
            {
                entity.ToTable("TEMP_ZONE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cntig)
                    .HasColumnName("CNTIG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ilot)
                    .HasColumnName("ILOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lot)
                    .HasColumnName("LOT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quartier)
                    .HasColumnName("QUARTIER")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempactiviteCodeActivite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEMPACTIVITE_CODE_ACTIVITE");

                entity.Property(e => e.TempactCode)
                    .HasColumnName("TEMPACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempactLibelle)
                    .HasColumnName("TEMPACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VActiviteAnalyseNationalite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ACTIVITE_ANALYSE_NATIONALITE");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontActId).HasColumnName("ACTCONT_ACT_ID");

                entity.Property(e => e.ActcontNom)
                    .HasColumnName("ACTCONT_NOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Annee)
                    .HasColumnName("ANNEE")
                    .HasColumnType("date");

                entity.Property(e => e.NatId).HasColumnName("NAT_ID");

                entity.Property(e => e.NatLibelle)
                    .HasColumnName("NAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VActiviteNationalite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ACTIVITE_NATIONALITE");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NatId).HasColumnName("NAT_ID");

                entity.Property(e => e.NatLibelle)
                    .HasColumnName("NAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<VComplementaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_COMPLEMENTAIRE");

                entity.Property(e => e.Batiments).HasColumnName("BATIMENTS");

                entity.Property(e => e.Commune)
                    .HasColumnName("COMMUNE")
                    .HasMaxLength(255);

                entity.Property(e => e.Eau).HasColumnName("EAU");

                entity.Property(e => e.Electricite).HasColumnName("ELECTRICITE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");

                entity.Property(e => e.NombreParcelleBati).HasColumnName("NOMBRE_PARCELLE_BATI");

                entity.Property(e => e.NombreParcelleNonBati).HasColumnName("NOMBRE_PARCELLE_NON_BATI");
            });

            modelBuilder.Entity<VContraventionValeur>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ContraventionValeur");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScCatId).HasColumnName("SC_CAT_ID");

                entity.Property(e => e.ScCatLibelle)
                    .HasColumnName("SC_CAT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScContId).HasColumnName("SC_CONT_ID");

                entity.Property(e => e.ScContLibelle)
                    .HasColumnName("SC_CONT_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScScatId).HasColumnName("SC_SCAT_ID");

                entity.Property(e => e.ScScatLibelle)
                    .HasColumnName("SC_SCAT_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScValDateEmission)
                    .HasColumnName("SC_VAL_DATE_EMISSION")
                    .HasColumnType("date");

                entity.Property(e => e.ScValId).HasColumnName("SC_VAL_ID");

                entity.Property(e => e.ScValValeur).HasColumnName("SC_VAL_VALEUR");

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<VContribuableActivteTaxeRetard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CONTRIBUABLE_ACTIVTE_TAXE_RETARD");

                entity.Property(e => e.ActCode)
                    .HasColumnName("ACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActDescription)
                    .HasColumnName("ACT_DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.ContDateImmatriculation)
                    .HasColumnName("CONT_DATE_IMMATRICULATION")
                    .HasColumnType("date");

                entity.Property(e => e.ContDateImmatriculationAnnuelle)
                    .HasColumnName("CONT_DATE_IMMATRICULATION_ANNUELLE")
                    .HasColumnType("date");

                entity.Property(e => e.ContId).HasColumnName("CONT_ID");

                entity.Property(e => e.ContMail)
                    .HasColumnName("CONT_MAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContMatricule)
                    .HasColumnName("CONT_MATRICULE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContMatriculeAnnuel)
                    .HasColumnName("CONT_MATRICULE_ANNUEL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNcc)
                    .HasColumnName("CONT_NCC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContNumPiece)
                    .HasColumnName("CONT_NUM_PIECE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContPieceCode)
                    .HasColumnName("CONT_PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContTelephone)
                    .HasColumnName("CONT_TELEPHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FactDerniereEcheance)
                    .HasColumnName("FACT_DERNIERE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontantRetard).HasColumnName("MONTANT_Retard");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCpteCode).HasColumnName("TAX_CPTE_CODE");

                entity.Property(e => e.TaxDescription)
                    .HasColumnName("TAX_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxactId).HasColumnName("TAXACT_ID");

                entity.Property(e => e.TaxfDescription)
                    .HasColumnName("TAXF_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<VContribuableQuartierNombre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CONTRIBUABLE_QUARTIER_NOMBRE");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDashboardFacture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DASHBOARD_FACTURE");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DashRecetteDate)
                    .HasColumnName("DASH_RECETTE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.DashRecetteId).HasColumnName("DASH_RECETTE_ID");

                entity.Property(e => e.DashRecettePrevision).HasColumnName("DASH_RECETTE_PREVISION");

                entity.Property(e => e.DashRecetteRecette).HasColumnName("DASH_RECETTE_RECETTE");

                entity.Property(e => e.DashRecetteRetard).HasColumnName("DASH_RECETTE_RETARD");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VDashboardQuartierTaxeDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DASHBOARD_QUARTIER_TAXE_DATE");

                entity.Property(e => e.Jour)
                    .HasColumnName("JOUR")
                    .HasColumnType("date");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VECentreElectoral>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_E_CENTRE_ELECTORAL");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CentId).HasColumnName("CENT_ID");

                entity.Property(e => e.CentLibelle)
                    .HasColumnName("CENT_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VEtatCollecte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ETAT_COLLECTE");

                entity.Property(e => e.AcolId).HasColumnName("ACOL_ID");

                entity.Property(e => e.AcolMatricule)
                    .HasColumnName("ACOL_MATRICULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcolNom)
                    .HasColumnName("ACOL_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcolPrenom)
                    .HasColumnName("ACOL_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgNom)
                    .HasColumnName("AG_Nom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgPrenoms)
                    .HasColumnName("AG_Prenoms")
                    .IsUnicode(false);

                entity.Property(e => e.ColDate)
                    .HasColumnName("COL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ColId).HasColumnName("COL_ID");

                entity.Property(e => e.ColMontant).HasColumnName("COL_MONTANT");

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactBAbandon).HasColumnName("FACT_bABANDON");

                entity.Property(e => e.FactBEtatReglement).HasColumnName("FACT_bETAT_REGLEMENT");

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactDateaBandon)
                    .HasColumnName("FACT_DATEA_BANDON")
                    .HasColumnType("date");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactLibelle)
                    .IsRequired()
                    .HasColumnName("FACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxTaxfId).HasColumnName("TAX_TAXF_ID");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneSecId).HasColumnName("ZONE_SEC_ID");
            });

            modelBuilder.Entity<VEtatRecette>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ETAT_RECETTE");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AgId).HasColumnName("AG_ID");

                entity.Property(e => e.AgNom)
                    .HasColumnName("AG_Nom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgPrenoms)
                    .HasColumnName("AG_Prenoms")
                    .IsUnicode(false);

                entity.Property(e => e.ContMail)
                    .HasColumnName("CONT_MAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContTelephone)
                    .HasColumnName("CONT_TELEPHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1).HasColumnType("datetime");

                entity.Property(e => e.FactBEtatReglement).HasColumnName("FACT_bETAT_REGLEMENT");

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactLibelle)
                    .IsRequired()
                    .HasColumnName("FACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaieColId).HasColumnName("PAIE_COL_ID");

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaieFactAgId).HasColumnName("PAIE_FACT_AG_ID");

                entity.Property(e => e.PaieFactId).HasColumnName("PAIE_FACT_ID");

                entity.Property(e => e.PaieId).HasColumnName("PAIE_ID");

                entity.Property(e => e.PaieMontant).HasColumnName("PAIE_MONTANT");

                entity.Property(e => e.PaieScValId).HasColumnName("PAIE_SC_VAL_ID");

                entity.Property(e => e.TaxId).HasColumnName("TAX_ID");

                entity.Property(e => e.TaxTaxfId).HasColumnName("TAX_TAXF_ID");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneSecId).HasColumnName("ZONE_SEC_ID");
            });

            modelBuilder.Entity<VFactureAnnee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_ANNEE");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");
            });

            modelBuilder.Entity<VFactureByQuartier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_BY_QUARTIER");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFactureByQuartierMoisCourant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_BY_QUARTIER_MOIS_COURANT");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFactureByQuartierRecouvert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_BY_QUARTIER_RECOUVERT");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VFactureDerniereEcheanceReglee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_DERNIERE_ECHEANCE_REGLEE");

                entity.Property(e => e.FactDerniereEcheance)
                    .HasColumnName("FACT_DERNIERE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactTaxactId).HasColumnName("FACT_TAXACT_ID");
            });

            modelBuilder.Entity<VFactureJournaliere>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_JOURNALIERE");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");
            });

            modelBuilder.Entity<VFactureMois>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FACTURE_MOIS");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");
            });

            modelBuilder.Entity<VFcatureByQuartierRecouvertMoisCourant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FCATURE_BY_QUARTIER_RECOUVERT_MOIS_COURANT");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProgrammeProjetAnnee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProgrammeProjetAnnee");

                entity.Property(e => e.AnneeId).HasColumnName("ANNEE_ID");

                entity.Property(e => e.AnneeLib)
                    .HasColumnName("ANNEE_LIB")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgAnAnneeId).HasColumnName("PROG_AN_ANNEE_ID");

                entity.Property(e => e.ProgAnId).HasColumnName("PROG_AN_ID");

                entity.Property(e => e.ProgAnProgId).HasColumnName("PROG_AN_PROG_ID");

                entity.Property(e => e.ProgDatedebut)
                    .HasColumnName("PROG_DATEDEBUT")
                    .HasColumnType("date");

                entity.Property(e => e.ProgDatefin)
                    .HasColumnName("PROG_DATEFIN")
                    .HasColumnType("date");

                entity.Property(e => e.ProgDescription)
                    .HasColumnName("PROG_DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.ProgId).HasColumnName("PROG_ID");

                entity.Property(e => e.ProgLibelle)
                    .HasColumnName("PROG_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgprojId).HasColumnName("PROGPROJ_ID");

                entity.Property(e => e.ProgprojNumordre).HasColumnName("PROGPROJ_NUMORDRE");

                entity.Property(e => e.ProgprojProgId).HasColumnName("PROGPROJ_PROG_ID");

                entity.Property(e => e.ProgprojProjId).HasColumnName("PROGPROJ_PROJ_ID");
            });

            modelBuilder.Entity<VProjetZone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ProjetZone");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.ProjCout).HasColumnName("PROJ_Cout");

                entity.Property(e => e.ProjDateDebut)
                    .HasColumnName("PROJ_DateDebut")
                    .HasColumnType("date");

                entity.Property(e => e.ProjDateFin)
                    .HasColumnName("PROJ_DateFin")
                    .HasColumnType("date");

                entity.Property(e => e.ProjDescription).HasColumnName("PROJ_Description");

                entity.Property(e => e.ProjEtatRealisation).HasColumnName("PROJ_EtatRealisation");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ProjIndicateur).HasColumnName("PROJ_Indicateur");

                entity.Property(e => e.ProjLibelle).HasColumnName("PROJ_Libelle");

                entity.Property(e => e.ProjMoeId).HasColumnName("PROJ_MOE_ID");

                entity.Property(e => e.ProjMouId).HasColumnName("PROJ_MOU_ID");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VProjetparquatier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_PROJETPARQUATIER");

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjBMarche).HasColumnName("PROJ_bMARCHE");

                entity.Property(e => e.ProjBTp).HasColumnName("PROJ_bTP");

                entity.Property(e => e.ProjCatId).HasColumnName("PROJ_CAT_ID");

                entity.Property(e => e.ProjCout).HasColumnName("PROJ_Cout");

                entity.Property(e => e.ProjDateDebut)
                    .HasColumnName("PROJ_DateDebut")
                    .HasColumnType("date");

                entity.Property(e => e.ProjDateFin)
                    .HasColumnName("PROJ_DateFin")
                    .HasColumnType("date");

                entity.Property(e => e.ProjDescription).HasColumnName("PROJ_Description");

                entity.Property(e => e.ProjEtatRealisation).HasColumnName("PROJ_EtatRealisation");

                entity.Property(e => e.ProjId).HasColumnName("PROJ_ID");

                entity.Property(e => e.ProjIndicateur).HasColumnName("PROJ_Indicateur");

                entity.Property(e => e.ProjLibelle).HasColumnName("PROJ_Libelle");

                entity.Property(e => e.ProjMoeId).HasColumnName("PROJ_MOE_ID");

                entity.Property(e => e.ProjMouId).HasColumnName("PROJ_MOU_ID");

                entity.Property(e => e.ProjZoneId).HasColumnName("PROJ_ZONE_ID");
            });

            modelBuilder.Entity<VQuartier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_QUARTIER");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoCommune)
                    .HasColumnName("COD_GEO_COMMUNE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoIlot)
                    .HasColumnName("COD_GEO_ILOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoLot)
                    .HasColumnName("COD_GEO_LOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoQuartier)
                    .HasColumnName("COD_GEO_QUARTIER")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.NumCntigCommune)
                    .HasColumnName("NUM_CNTIG_COMMUNE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigIlo)
                    .HasColumnName("NUM_CNTIG_ILO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigLot)
                    .HasColumnName("NUM_CNTIG_LOT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntigQuartier)
                    .HasColumnName("NUM_CNTIG_QUARTIER")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VRecettteMontant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RECETTTE_MONTANT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Periodicite)
                    .IsRequired()
                    .HasColumnName("periodicite")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VRecouvrementCarte>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RECOUVREMENT_CARTE");

                entity.Property(e => e.ActcontActId).HasColumnName("ACTCONT_ACT_ID");

                entity.Property(e => e.ActcontPlaqueOld)
                    .HasColumnName("ACTCONT_PLAQUE_OLD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MontantImpaye).HasColumnName("MONTANT_IMPAYE");

                entity.Property(e => e.NombreImpaye).HasColumnName("NOMBRE_IMPAYE");

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxTaxfId).HasColumnName("TAX_TAXF_ID");

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneSecId).HasColumnName("ZONE_SEC_ID");
            });

            modelBuilder.Entity<VResActiviteContribuable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_ACTIVITE_CONTRIBUABLE");

                entity.Property(e => e.ActBOdp).HasColumnName("ACT_bODP");

                entity.Property(e => e.ActCode)
                    .HasColumnName("ACT_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActDescription)
                    .HasColumnName("ACT_DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActTaxeMoyenneAn).HasColumnName("ACT_TAXE_MOYENNE_AN");

                entity.Property(e => e.ActTaxeMoyenneJour).HasColumnName("ACT_TAXE_MOYENNE_JOUR");

                entity.Property(e => e.ActTaxeMoyenneMois).HasColumnName("ACT_TAXE_MOYENNE_MOIS");

                entity.Property(e => e.ActconAgentDecision).HasColumnName("ACTCON_AGENT_DECISION");

                entity.Property(e => e.ActconDatePriseDecision)
                    .HasColumnName("ACTCON_DATE_PRISE_DECISION")
                    .HasColumnType("date");

                entity.Property(e => e.ActcontActId).HasColumnName("ACTCONT_ACT_ID");

                entity.Property(e => e.ActcontActiviteId).HasColumnName("ACTCONT_ACTIVITE_ID");

                entity.Property(e => e.ActcontAgentFermetureDemande).HasColumnName("ACTCONT_AGENT_FERMETURE_DEMANDE");

                entity.Property(e => e.ActcontAgentIntroDemande).HasColumnName("ACTCONT_AGENT_INTRO_DEMANDE");

                entity.Property(e => e.ActcontBDecisionFermeture).HasColumnName("ACTCONT_bDECISION_FERMETURE");

                entity.Property(e => e.ActcontBDecisionMes).HasColumnName("ACTCONT_bDECISION_MES");

                entity.Property(e => e.ActcontBOdp).HasColumnName("ACTCONT_bODP");

                entity.Property(e => e.ActcontContId).HasColumnName("ACTCONT_CONT_ID");

                entity.Property(e => e.ActcontDateFermetureDemande)
                    .HasColumnName("ACTCONT_DATE_FERMETURE_DEMANDE")
                    .HasColumnType("date");

                entity.Property(e => e.ActcontDateIntroDemande)
                    .HasColumnName("ACTCONT_DATE_INTRO_DEMANDE")
                    .HasColumnType("date");

                entity.Property(e => e.ActcontFermetureRaison)
                    .HasColumnName("ACTCONT_FERMETURE_RAISON")
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.ActcontNom)
                    .HasColumnName("ACTCONT_NOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaqueOld)
                    .HasColumnName("ACTCONT_PLAQUE_OLD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontRefId).HasColumnName("ACTCONT_REF_ID");

                entity.Property(e => e.ActcontZoneId).HasColumnName("ACTCONT_ZONE_ID");

                entity.Property(e => e.ActontAgentFermetureDecision)
                    .HasColumnName("ACTONT_AGENT_FERMETURE_DECISION")
                    .HasColumnType("date");

                entity.Property(e => e.ActontDateFermetureDecision)
                    .HasColumnName("ACTONT_DATE_FERMETURE_DECISION")
                    .HasColumnType("date");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoCommune)
                    .HasColumnName("COD_GEO_COMMUNE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoIlot)
                    .HasColumnName("COD_GEO_ILOT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoLot)
                    .HasColumnName("COD_GEO_LOT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoQuartier)
                    .HasColumnName("COD_GEO_QUARTIER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContDateImmatriculation)
                    .HasColumnName("CONT_DATE_IMMATRICULATION")
                    .HasColumnType("date");

                entity.Property(e => e.ContDateImmatriculationAnnuelle)
                    .HasColumnName("CONT_DATE_IMMATRICULATION_ANNUELLE")
                    .HasColumnType("date");

                entity.Property(e => e.ContId).HasColumnName("CONT_ID");

                entity.Property(e => e.ContMail)
                    .HasColumnName("CONT_MAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContMatricule)
                    .HasColumnName("CONT_MATRICULE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContMatriculeAnnuel)
                    .HasColumnName("CONT_MATRICULE_ANNUEL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNcc)
                    .HasColumnName("CONT_NCC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContNumPiece)
                    .HasColumnName("CONT_NUM_PIECE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContPieceCode)
                    .HasColumnName("CONT_PIECE_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContTelephone)
                    .HasColumnName("CONT_TELEPHONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.NumCntigCommune).HasColumnName("NUM_CNTIG_COMMUNE");

                entity.Property(e => e.NumCntigIlo).HasColumnName("NUM_CNTIG_ILO");

                entity.Property(e => e.NumCntigLot).HasColumnName("NUM_CNTIG_LOT");

                entity.Property(e => e.NumCntigQuartier).HasColumnName("NUM_CNTIG_QUARTIER");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RefAlpha)
                    .HasColumnName("REF_ALPHA")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefDescription)
                    .HasColumnName("REF_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefEspId).HasColumnName("REF_ESP_ID");

                entity.Property(e => e.RefNumCntig).HasColumnName("REF_NUM_CNTIG");

                entity.Property(e => e.RefNumMairie)
                    .HasColumnName("REF_NUM_MAIRIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumerique).HasColumnName("REF_NUMERIQUE");

                entity.Property(e => e.RefTaId).HasColumnName("REF_TA_ID");

                entity.Property(e => e.RefTlId).HasColumnName("REF_TL_ID");

                entity.Property(e => e.RefValeur)
                    .HasColumnName("REF_VALEUR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefZoneId).HasColumnName("REF_ZONE_ID");

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TaCode)
                    .HasColumnName("TA_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaDescription)
                    .HasColumnName("TA_DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaId).HasColumnName("TA_ID");

                entity.Property(e => e.TaLibelle)
                    .HasColumnName("TA_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VResCollecteRealisee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_COLLECTE_REALISEE");

                entity.Property(e => e.AcolId).HasColumnName("ACOL_ID");

                entity.Property(e => e.AcolMatricule)
                    .HasColumnName("ACOL_MATRICULE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ColBExportPaiement).HasColumnName("COL_bEXPORT_PAIEMENT");

                entity.Property(e => e.ColDate)
                    .HasColumnName("COL_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ColId).HasColumnName("COL_ID");

                entity.Property(e => e.ColMontant).HasColumnName("COL_MONTANT");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasColumnName("ZONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<VResFacture>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_FACTURE");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.ActcontNom)
                    .HasColumnName("ACTCONT_NOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontPlaque)
                    .HasColumnName("ACTCONT_PLAQUE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontRefId).HasColumnName("ACTCONT_REF_ID");

                entity.Property(e => e.ActcontZoneId).HasColumnName("ACTCONT_ZONE_ID");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContId).HasColumnName("CONT_ID");

                entity.Property(e => e.ContNcc)
                    .HasColumnName("CONT_NCC")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContNom)
                    .HasColumnName("CONT_NOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContPrenom)
                    .HasColumnName("CONT_PRENOM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CpteCode).HasColumnName("CPTE_CODE");

                entity.Property(e => e.CpteLibelle)
                    .HasColumnName("CPTE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Expr10)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr5)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr6)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Expr9)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactAbandonAgId).HasColumnName("FACT_ABANDON_AG_ID");

                entity.Property(e => e.FactAbandonMotif)
                    .HasColumnName("FACT_ABANDON_MOTIF")
                    .IsUnicode(false);

                entity.Property(e => e.FactBAbandon).HasColumnName("FACT_bABANDON");

                entity.Property(e => e.FactBEtatReglement).HasColumnName("FACT_bETAT_REGLEMENT");

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactDateEmission)
                    .HasColumnName("FACT_DATE_EMISSION")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactDateaBandon)
                    .HasColumnName("FACT_DATEA_BANDON")
                    .HasColumnType("date");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactLibelle)
                    .IsRequired()
                    .HasColumnName("FACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.FactPeriodeDebut)
                    .HasColumnName("FACT_PERIODE_DEBUT")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactPeriodeFin)
                    .HasColumnName("FACT_PERIODE_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactPotentiel).HasColumnName("FACT_POTENTIEL");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId).HasColumnName("TAX_ID");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxactId).HasColumnName("TAXACT_ID");

                entity.Property(e => e.TaxfDescription)
                    .HasColumnName("TAXF_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfUrlImage)
                    .HasColumnName("TAXF_URL_IMAGE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneSecId).HasColumnName("ZONE_SEC_ID");
            });

            modelBuilder.Entity<VResFactureDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_FACTURE_DASHBOARD");

                entity.Property(e => e.CodGeoQuartier)
                    .HasColumnName("COD_GEO_QUARTIER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactBEtatReglement).HasColumnName("FACT_bETAT_REGLEMENT");

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactPotentiel).HasColumnName("FACT_POTENTIEL");

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VResFactureSoldee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_FACTURE_SOLDEE");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ActcontId).HasColumnName("ACTCONT_ID");

                entity.Property(e => e.CpteCode).HasColumnName("CPTE_CODE");

                entity.Property(e => e.CpteLibelle)
                    .HasColumnName("CPTE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactCode)
                    .IsRequired()
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactDateEcheance)
                    .HasColumnName("FACT_DATE_ECHEANCE")
                    .HasColumnType("date");

                entity.Property(e => e.FactId).HasColumnName("FACT_ID");

                entity.Property(e => e.FactMontant).HasColumnName("FACT_MONTANT");

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaieId).HasColumnName("PAIE_ID");

                entity.Property(e => e.TaxId).HasColumnName("TAX_ID");

                entity.Property(e => e.TaxLibelle)
                    .HasColumnName("TAX_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxactId).HasColumnName("TAXACT_ID");
            });

            modelBuilder.Entity<VResFactureTaxactRetard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_FACTURE_TAXACT_RETARD");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FactTaxactId).HasColumnName("FACT_TAXACT_ID");

                entity.Property(e => e.Montant).HasColumnName("MONTANT");

                entity.Property(e => e.Nombre).HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<VResRecette>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RES_RECETTE");

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FactCode)
                    .HasColumnName("FACT_CODE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaieDate)
                    .HasColumnName("PAIE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaieId).HasColumnName("PAIE_ID");

                entity.Property(e => e.PaieMontant).HasColumnName("PAIE_MONTANT");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ScContLibelle)
                    .HasColumnName("SC_CONT_LIBELLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Zone)
                    .HasColumnName("ZONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");
            });

            modelBuilder.Entity<VRetardAgregats>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_RETARD_AGREGATS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Periode)
                    .IsRequired()
                    .HasColumnName("periode")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VRevenuParActivite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_REVENU_PAR_ACTIVITE");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActLibelle)
                    .HasColumnName("ACT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Annee).HasColumnName("ANNEE");

                entity.Property(e => e.EspId).HasColumnName("ESP_ID");

                entity.Property(e => e.EspLibelle)
                    .HasColumnName("ESP_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Montant).HasColumnName("montant");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.Officiel).HasColumnName("officiel");

                entity.Property(e => e.TaCode)
                    .IsRequired()
                    .HasColumnName("TA_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaId).HasColumnName("TA_ID");

                entity.Property(e => e.TaLibelle)
                    .HasColumnName("TA_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTaxeQuartier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TAXE_QUARTIER");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTaxeQuartierRetard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TAXE_QUARTIER_RETARD");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTaxeZone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TAXE_ZONE");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTaxeZoneRetard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_TAXE_ZONE_RETARD");

                entity.Property(e => e.TaxfId).HasColumnName("TAXF_ID");

                entity.Property(e => e.TaxfLibelle)
                    .HasColumnName("TAXF_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VZone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ZONE");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoCommune)
                    .HasColumnName("COD_GEO_COMMUNE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoIlot)
                    .HasColumnName("COD_GEO_ILOT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoLot)
                    .HasColumnName("COD_GEO_LOT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeoQuartier)
                    .HasColumnName("COD_GEO_QUARTIER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.NumCntigCommune).HasColumnName("NUM_CNTIG_COMMUNE");

                entity.Property(e => e.NumCntigIlo).HasColumnName("NUM_CNTIG_ILO");

                entity.Property(e => e.NumCntigLot).HasColumnName("NUM_CNTIG_LOT");

                entity.Property(e => e.NumCntigQuartier).HasColumnName("NUM_CNTIG_QUARTIER");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VZoneEauElectricite>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ZONE_EAU_ELECTRICITE");

                entity.Property(e => e.Eau).HasColumnName("EAU");

                entity.Property(e => e.Electricite).HasColumnName("ELECTRICITE");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VZoneOccupationNombre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ZONE_OCCUPATION_NOMBRE");

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VZonePrimaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ZONE_PRIMAIRE");

                entity.Property(e => e.Categorie)
                    .HasColumnName("CATEGORIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodGeo)
                    .HasColumnName("COD_GEO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CommuneId).HasColumnName("COMMUNE_ID");

                entity.Property(e => e.CommuneLibelle)
                    .HasColumnName("COMMUNE_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.IdCat).HasColumnName("ID_CAT");

                entity.Property(e => e.IdTypezone).HasColumnName("ID_TYPEZONE");

                entity.Property(e => e.IlotId).HasColumnName("ILOT_ID");

                entity.Property(e => e.IlotLibelle)
                    .HasColumnName("ILOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Libelle)
                    .HasColumnName("LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotId).HasColumnName("LOT_ID");

                entity.Property(e => e.LotLibelle)
                    .HasColumnName("LOT_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumCntig).HasColumnName("NUM_CNTIG");

                entity.Property(e => e.QuartierId).HasColumnName("QUARTIER_ID");

                entity.Property(e => e.QuartierLibelle)
                    .HasColumnName("QUARTIER_LIBELLE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SpgeGpsLat).HasColumnName("SPGE_GPS_LAT");

                entity.Property(e => e.SpgeGpsLon).HasColumnName("SPGE_GPS_LON");

                entity.Property(e => e.SpgeRepere).HasColumnName("SPGE_REPERE");

                entity.Property(e => e.TypezoneLibelle)
                    .HasColumnName("TYPEZONE_LIBELLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId).HasColumnName("ZONE_ID");

                entity.Property(e => e.ZoneLibelle)
                    .HasColumnName("ZONE_LIBELLE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
