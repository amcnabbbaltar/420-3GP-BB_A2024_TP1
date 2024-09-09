using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ConstantesSimulation
{
        public const double FACTEUR_ACCELERATION = 200;
        public const double MILLIS_PAR_MINUTE = 60000.0 / FACTEUR_ACCELERATION;

        // Délai entre chaque commande (au téléphone)
        public const int DELAI_MINIMUM_COMMANDE_TELEPHONE = (int)(3 * MILLIS_PAR_MINUTE);
        public const int DELAI_MAXIMUM_COMMANDE_TELEPHONE = (int)(7 * MILLIS_PAR_MINUTE);

        // Délai entre chaque commande (en salle à manger)
        public const int DELAI_MINIMUM_COMMANDE_SALLE = (int)(5 * MILLIS_PAR_MINUTE);
        public const int DELAI_MAXIMUM_COMMANDE_SALLE = (int)(10 * MILLIS_PAR_MINUTE);

        // Temps de préparation d'une commande en cuisine (dépend des ingrédients disponibles)
        public const int TEMPS_MINIMUM_PREPARATION = (int)(8 * MILLIS_PAR_MINUTE);
        public const int TEMPS_MAXIMUM_PREPARATION = (int)(14 * MILLIS_PAR_MINUTE);

        // Temps supplémentaire si l'ingrédient n'est pas en stock
        public const int DELAI_REAPPROVISIONNEMENT_INGREDIENT = (int)(6 * MILLIS_PAR_MINUTE);

        // Temps de déplacement pour se déplacer d'une case
        public const int TEMPS_DEPLACEMENT = (int)(1 * MILLIS_PAR_MINUTE);

        // Temps de paiement une fois la commande livrée
        public const int TEMPS_PAIEMENT = (int)(2 * MILLIS_PAR_MINUTE);

        // Temps maximal acceptable pour une commande (avant annulation ou pénalité)
        public const int TEMPS_MAXIMAL_ATTENTE = (int)(45 * MILLIS_PAR_MINUTE);

        // Nombre de commandes pour chaque source (livraison, salle à manger, emporter)
        public const int NOMBRE_COMMANDES_LIVRAISON = 5;
        public const int NOMBRE_COMMANDES_SALLE = 20;
        public const int NOMBRE_COMMANDES_EMPORTER = 15;

        // Nombre de cuisiniers et livreurs
        public const int NOMBRE_CUISINIERS = 3;
        public const int NOMBRE_LIVREURS = 4;

        // Nombre de tables dans la salle à manger
        public const int NOMBRE_TABLES_SALLE = 8;

        // Seuil critique pour déclencher le réapprovisionnement automatique des Repas
        public const int SEUIL_CRITIQUE_REPAS = 2;

        // Nombre maximal de plats dans une commande (1-10 pour emporter/livraison, 1-4 pour salle à manger)
        public const int NOMBRE_MAX_PLATS_COMMANDE_LIVRAISON = 10;
        public const int NOMBRE_MAX_PLATS_COMMANDE_SALLE = 4;

        // Distance maximale de livraison (en cases)
        public const int DISTANCE_MAXIMALE_LIVRAISON = 10;
    
}

