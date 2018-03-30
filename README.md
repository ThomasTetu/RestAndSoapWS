# RestAndSoapWS

## Arborescence et Lancement

Le projet est divisé en 2.

* Une solution contenant l'IWS SOAP et le client console, utilisante cet IWS.
* Une solution conteant le client GUI, appelant les méthodes asynchrone de l'IWS.

Il est impératif de lancer l'IWS antérieurement au lancement des clients.
Le lancement du client console se fait dans la solution contenant l'IWS.
Le lancement du client GUI se fait à l'extérieur, dans sa propre solution, sur visual studio.

## MVP

IWS Soap effectué, passant des listes de strings pour les villes et les stations d'une ville, et un objet Station (DataContract), passé pour donner les informations d'un station particulière.

Client console, avec commande d'aide, utilisant les méthode de l'IWS Soap pour récupérer les informations utiles.

## Extensions

* GUI
    * Application Windows Form contenant deux comboBox pour afficher les listes des villes et des stations. Label pour afficher le nombre de vélo disponible pour une station séléctionnée. Et affichage de la localisation de la station, à l'aide de GMap .Net.

* Méthodes Asynchrones
    * Ajout des méthodes asynchrone dans l'IWS Soap, et utilisées par l'Application Windows Form.

* Cache
    * L'IWS est munis d'une DataTable, enregistrant les données des stations déjà recherchés, permettant d'accéder plus rapidement aux données d'une station qui ont déjà été demandées, elles sont rafraichis aprés plus de cinq minutes.

### ***Project By Thomas TETU***
