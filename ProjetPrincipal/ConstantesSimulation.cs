using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ConstantesSimulation
{
    // Thread de gestion du temps
    public const int TEMPS_SIMULATION_MS = 180000;
    public const int INTERVALLE_AFFICHAGE_TEMPS_MS = 30000;
    
    // Thread telephonique
    public const int INTERVALLE_COMMANDE_TEL_MIN_MS = 1500;
    public const int INTERVALLE_COMMANDE_TEL_MAX_MS = 2500;

    // Thread de Salle a Manger 
    public const int NB_TABLES_INITIAL = 8;
    public const int DELAI_LIBERATION_TABLE_MIN_MS = 15000;
    public const int DELAI_LIBERATION_TABLE_MAX_MS = 20000;

    // Constantes pour la cuisine 
    public const int TEMPS_PREPARATION_PAR_PLAT_MS = 500;

    //Constantes pour le délai maximal des commandes
    public const int DELAI_MAX_SALLE_A_MANGER_MS = 30000;
    public const int DELAI_MAX_LIVRAISON_MS = 20000;
    public const int DELAI_MAX_POUR_EMPORTER_MS = 40000;

    // Constantes pour la gestion de l'inventaire
    public const int SEUIL_CRITIQUE_REAPPROVISIONNEMENT = 2;
    public const int TEMPS_REAPPROVISIONNEMENT_MIN_MS = 5000;

    public const int TEMPS_REAPPROVISIONNEMENT_MAX_MS = 10000;

}


