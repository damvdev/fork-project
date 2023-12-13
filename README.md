# fork-project

## Canvis fets:

- S'ha eliminat la variable discount i tot el relacionat amb aquesta, ja que no aportaba res al resultat.
- S'ha eliminat el mètode PrintHeader i s'ha canviat per una constant que es printa al principi del codi.
- S'han eliminat els mètodes EntradaGratis i Jubilat, eren bastant innecessaris i els he substituit per un
operador ternari que indica si té o no la entrada gratis.
- Tot l'output s'ha mogut al mètode PrintCompte, que ara no és del tipus void, és string.