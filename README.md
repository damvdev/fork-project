# fork-project

## Canvis

- S'han transformat tots els missatges de text en constants.
- S'ha substituït la variable num amb la variable discount. 
- S'ha eliminat el mètode PrintHeader i s'ha implementat el seu contingut en un únic missatge al codi principal.
- S'han eliminat els mètodes EntradaGratis i Jubilat. A canvi, s'ha afegit al principi una validació per a veure si el client és major de 65 anys.
- Si el client és major de 65 anys s'utilitza el mètode PrintCompte per a indicar que la entrada és gratis.
- Si no ho és s'utilitza el mètode PrintCompte, però ara amb el discount, per a indicar totes les dades necessàries.
- El text del mètode PrintCompte ha sigut alterat per a que quan digui "nom: " mostri el nom en comptes de la edat i a l'inversa.
