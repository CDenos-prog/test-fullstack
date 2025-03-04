# Lancer l'application .Net

## Prérequis

- .Net SDK installé
- Visual Studio Code ou tout autre éditeur de code

## Étapes pour lancer l'application

1. Ouvrez un terminal.
2. Naviguez vers le dossier `back` :
    ```sh
    cd back
    ```
3. Restaurez les packages NuGet :
    ```sh
    dotnet restore
    ```
4. Compilez l'application :
    ```sh
    dotnet build
    ```
5. Lancez l'application :
    ```sh
    dotnet run
    ```

## Structure du projet

- `Program.cs` : Point d'entrée de l'application.
- `Startup.cs` : Configuration des services et du pipeline de requêtes.
- `Controllers/` : Contient les contrôleurs API.

## Support

Pour toute question ou problème, veuillez ouvrir une issue sur le dépôt GitHub.

# Autoévaluation

Arrivé à 17h, il restait malheureusement trop de travail à faire, notemment l'interface front sur laquelle je n'ai pas eu le temps de travailler, ayant été trop occupé avec la conception de l'API en .Net (dont le manuel d'éxécution se trouve juste au dessus). J'ai néanmoins réussi à implémenter quasiment toutes les fonctionnalités back demandées (la seule manquante étant les retours de personnes ayant travaillées pour une entreprise précise et les personnes ayant travaillés entre deux dates mais je suis convaincu qu'avec un peu plus de temps, j'aurais pu implémenter ces fonctionnalités). 