# Tuto Entity

## Select

```csharp
Dim users = New testEntities().users
```

- Selectionne tout les users dans la bd.
- Retourne un **DbSet** qui agit comme une liste.
- Le DbSet ne load pas tout les enregistrement en memoire.


## Fonction sur les DbSet

### Add

```csharp
Dim users = New testEntities().users
Dim usr = New user()
usr.BirthDate = Date.Now
usr.FirstName = "Marc"
usr.LastName = "Quessy"
users.Add(usr)
```

- Ajoute un enregistrement au **contexte**.
- L'enregistrement est sauvegarder dans la BD a l'appel de la methode **SaveChanges**

### First

- Pour trouver le **premier** element 
```csharp
Dim users = New testEntities().users
users.First()
```

- Pour trouver le **premier** un element qui repond a une condition
```csharp
Dim users = New testEntities().users
users.First(Function(usr) usr.FirstName == "Marc")
```

- On passe une fonction a la methode **First** qui recois un **user en parametre et retourne un boolean** determinant si le user est selectioné ou non.


### Remove

```csharp
Dim users = New testEntities().users
Dim first = users.First()
users.Remove(first)
```

- Retire un enregistrement.
- L'enregistrement est retiré dans la BD a l'appel de la methode **SaveChanges**


### Where

```csharp
Dim users = New testEntities().users
Dim majeur = users.Where(Function(usr) Date.Now.Year - usr.BirthDate.Year > 1)
```
- On passe une fonction a la methode **Where** qui recois un **user en parametre et retourne un boolean** determinant si le user est selectioné ou non.
- Selectionne **tout** les users qui valide la condition.