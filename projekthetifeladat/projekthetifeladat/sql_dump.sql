--CREATE DATABASE musor;
--USE musor;

CREATE TABLE musor (
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    cime VARCHAR(50) NOT NULL,
    leiras VARCHAR(255) NOT NULL,
    mufaj VARCHAR(25) NOT NULL,
    kiadasi_ev INTEGER NOT NULL,
    borito VARCHAR(100) NOT NULL
);

CREATE TABLE szereplok
(
    id INTEGER IDENTITY(1,1) PRIMARY KEY,
    m_id INTEGER NOT NULL,
    cim VARCHAR(50) NOT NULL,
    szereplo VARCHAR(50) NOT NULL,
    szulev INTEGER NOT NULL
);

INSERT INTO musor (cime, leiras, mufaj, kiadasi_ev, borito) 
VALUES 
('Avatar', 'A víz útja','Fantasy','2022','avatar.jpg'),
('Periferia','A jövőben játszódik, amikor a technológia finoman megváltoztatta a társadalmat.','Drama','2022','periferia.jpg'),
('Igazából szerelem','Nyolc nagyon különböző pár életét követi nyomon, akik szerelmi életükkel foglalkoznak.','Romance','2003','igazabolszerelem.jpg'),
('Reacher','Jack Reachert letartóztatták gyilkosság miatt, és most a rendőrségnek szüksége van a segítségére.','Akcio','2022','reacher.jpg'),
('Mátrix', 'Ahogy látjuk: Szürke, egyhangú világunk valóságos.', 'Sci-fi', '1999', 'matrix.jpg'),
('A dada','A bevándorló dada, Aisha, aki új életet kezd New Yorkban.','Drama','2022','adada.jpg'),
('A Fiúk','Egy csoport éber arra indult, hogy legyőzzék a szuperképességükkel visszaélő korrupt szuperhősöket.','Akcio','2019','afiuk.jpg'),
('Vérapó','Amikor egy csapat zsoldos megtámadja egy gazdag család birtokát','Akcio','2022','verapo.jpg'),
('Babylon','több szereplő felemelkedését és bukását követi nyomon a korai Hollywoodban.','Comedy','2022','babylon.jpg'),
('Schindler listája', 'Egyetlen ember is képes lehet arra, hogy a körülmények ellenére megváltoztassa a dolgok menetét', 'Dráma', '1993', 'schindler.jpg'),
('Grincs','Whoville külvárosában él egy zöld, bosszúvágyó Grinch.','Comedy','2000','.grincs.jpg'),
('Evil Dead Rise', 'Fordulatos történet két elidegenedett nővérről.', 'Horror', '2023', 'evildeadrise.jpg');


INSERT INTO szereplok (m_id, cim, szereplo, szulev) 
VALUES ('1', 'Avatar', 'Sam Worthington', '1976'),
 ('2', 'Periferia', 'Chloë Grace Moretz', '1997'),
 ('3', 'Igazából szerelem', 'Hugh Grant', '1960'),
 ('4', 'Reacher','Alan Ritchson','1982'),
 ('5', 'Mátrix', 'Laurence Fishburne', '1961'),
 ('6', 'A dada','Anna Diop','1988'),
 ('7', 'A Fiúk','Karl Urban','1972'),
 ('8', 'Vérapó','David Harbour','1975'),
 ('9', 'Babylon','Brad Pitt','1963'),
 ('10', 'Schindler listája', 'Liam Neeson', '1952'),
 ('11', 'Grincs','Jim Carrey','1962'),
 ('11', 'Evil Dead Rise','Alyssa Sutherland','1982');