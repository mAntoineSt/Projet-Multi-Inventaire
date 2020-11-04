create table individus (
id_individu varchar(10), 
nom varchar(30), 
prenom varchar(30), 
adresse varchar(60), 
departement varchar(20), 
statut int, 
telephone char(10), 
courriel varchar(30), 
motdepasse varchar(255), 
primary key(id_individu)
);

create table equipements (
id_equipement char(20) primary key, 
nom varchar(30), 
description varchar(70), 
categorie varchar(20), 
etat varchar(20), 
date_enregistrement datetime, 
date_indisponible datetime, 
date_retrait datetime
);

create table emprunteurs (
id_emprunteur varchar(10) primary key, 
foreign key (id_emprunteur) references individus(id_individu)
);

create table preteurs (
id_preteur varchar(10) primary key, 
foreign key (id_preteur) references individus(id_individu)
);

create table prets (
id_pret char(10) primary key, 
id_emprunteur varchar(10),
foreign key (id_emprunteur) references emprunteurs(id_emprunteur), 
id_preteur varchar(10), 
foreign key (id_preteur) references preteurs(id_preteur), 
id_equipement char(20), 
foreign key (id_equipement) references equipements(id_equipement), 
date_emprunt date, 
date_retour date
);

create table retours (
id_retour char(10) primary key, 
id_emprunteur varchar(10), 
foreign key (id_emprunteur) references emprunteurs(id_emprunteur), 
id_preteur varchar(10), 
foreign key (id_preteur) references preteurs(id_preteur), 
id_equipement char(20), 
foreign key (id_equipement) references equipements(id_equipement), 
date_retour_prevue date, 
date_retour date
);

create table conditions (
id_condition char(10) primary key, 
description varchar(200)
);

create table responsabilites (
id_responsabilite char(10) primary key, 
description varchar(200)
);

create table conditions_equipements (
id_equipement char(10), 
foreign key (id_equipement) references equipements(id_equipement), 
id_condition char(10), 
foreign key (id_condition) references conditions(id_condition), 
primary key (id_equipement, id_condition)
);

create table responsabilites_equipements (
id_equipement char(10), 
foreign key (id_equipement) references equipements(id_equipement), 
id_responsabilite char(10), 
foreign key (id_responsabilite) references responsabilites(id_responsabilite), 
primary key (id_equipement, id_responsabilite)
);

create table retards (
id_retard char(15) primary key, 
id_retour char(10),
foreign key (id_retour) references retours(id_retour), 
constat varchar(200), 
montant_dommages double
);