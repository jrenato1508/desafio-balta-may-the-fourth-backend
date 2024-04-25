CREATE TABLE [StarShips] 
(
	[id]	uniqueidentifier
    [name]	VARCHAR(512),
    [model]	VARCHAR(512),
    [manufacturer]	VARCHAR(512),
    [cost_in_credits]	VARCHAR(512),
    [length]	VARCHAR(512),
    [max_atmosphering_speed]	VARCHAR(512),
    [crew]	VARCHAR(512),
    [passengers]	VARCHAR(512),
    [cargo_capacity]	VARCHAR(512),
    [consumables]	VARCHAR(512),
    [hyperdrive_rating]	VARCHAR(512),
    [MGLT]	VARCHAR(512),
    [starship_class]	VARCHAR(512),
    [pilots]	VARCHAR(512),
    [films]	VARCHAR(512),
    [created]	VARCHAR(512),
    [edited]	VARCHAR(512),
    [url]	VARCHAR(512)
);

INSERT INTO [StarShips]  VALUES
	('2941d46c-77bd-4b02-8f26-eb9aa0b13ac7','CR90 corvette', 'CR90 corvette', 'Corellian Engineering Corporation', '3500000', '150', '950', '30-165', '600', '3000000', '1 year', '2.0', '60', 'corvette', '', 'https://swapi.dev/api/films/1/,https://swapi.dev/api/films/3/,https://swapi.dev/api/films/6/', '2014-12-10T14:20:33.369000Z', '2014-12-20T21:23:49.867000Z', 'https://swapi.dev/api/starships/2/'),
	('18fea016-7cbe-4466-8924-c75449b543d4','Star Destroyer', 'Imperial I-class Star Destroyer', 'Kuat Drive Yards', '150000000', '1,600', '975', '47,060', 'n/a', '36000000', '2 years', '2.0', '60', 'Star Destroyer', '', 'https://swapi.dev/api/films/1/,https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-10T15:08:19.848000Z', '2014-12-20T21:23:49.870000Z', 'https://swapi.dev/api/starships/3/'),
	('30efe683-831a-4bf0-b691-72e91803e339','Sentinel-class landing craft', 'Sentinel-class landing craft', 'Sienar Fleet Systems, Cyngus Spaceworks', '240000', '38', '1000', '5', '75', '180000', '1 month', '1.0', '70', 'landing craft', '', 'https://swapi.dev/api/films/1/', '2014-12-10T15:48:00.586000Z', '2014-12-20T21:23:49.873000Z', 'https://swapi.dev/api/starships/5/'),
	('aad9b47d-1c6b-40e5-a242-42f78e85688b','Death Star', 'DS-1 Orbital Battle Station', 'Imperial Department of Military Research, Sienar Fleet Systems', '1000000000000', '120000', 'n/a', '342,953', '843,342', '1000000000000', '3 years', '4.0', '10', 'Deep Space Mobile Battlestation', '', 'https://swapi.dev/api/films/1/', '2014-12-10T16:36:50.509000Z', '2014-12-20T21:26:24.783000Z', 'https://swapi.dev/api/starships/9/'),
	('d38eeb45-3965-4ee6-bc54-83086a3dd9ab','Millennium Falcon', 'YT-1300 light freighter', 'Corellian Engineering Corporation', '100000', '34.37', '1050', '4', '6', '100000', '2 months', '0.5', '75', 'Light freighter', 'https://swapi.dev/api/people/13/,https://swapi.dev/api/people/14/,https://swapi.dev/api/people/25/,https://swapi.dev/api/people/31/', 'https://swapi.dev/api/films/1/,https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-10T16:59:45.094000Z', '2014-12-20T21:23:49.880000Z', 'https://swapi.dev/api/starships/10/'),
	('3beebb15-e3b6-4100-8eba-1ca83c6cc036','Y-wing', 'BTL Y-wing', 'Koensayr Manufacturing', '134999', '14', '1000km', '2', '0', '110', '1 week', '1.0', '80', 'assault starfighter', '', 'https://swapi.dev/api/films/1/,https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-12T11:00:39.817000Z', '2014-12-20T21:23:49.883000Z', 'https://swapi.dev/api/starships/11/'),
	('7d77ee72-f630-48da-9972-7364772228cc','X-wing', 'T-65 X-wing', 'Incom Corporation', '149999', '12.5', '1050', '1', '0', '110', '1 week', '1.0', '100', 'Starfighter', 'https://swapi.dev/api/people/1/,https://swapi.dev/api/people/9/,https://swapi.dev/api/people/18/,https://swapi.dev/api/people/19/', 'https://swapi.dev/api/films/1/,https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-12T11:19:05.340000Z', '2014-12-20T21:23:49.886000Z', 'https://swapi.dev/api/starships/12/'),
	('ffd00304-9f62-409d-b5d3-aad115ba9a07','TIE Advanced x1', 'Twin Ion Engine Advanced x1', 'Sienar Fleet Systems', 'unknown', '9.2', '1200', '1', '0', '150', '5 days', '1.0', '105', 'Starfighter', 'https://swapi.dev/api/people/4/', 'https://swapi.dev/api/films/1/', '2014-12-12T11:21:32.991000Z', '2014-12-20T21:23:49.889000Z', 'https://swapi.dev/api/starships/13/'),
	('104e588f-2425-4fdf-8992-0d217380ad42','Executor', 'Executor-class star dreadnought', 'Kuat Drive Yards, Fondor Shipyards', '1143350000', '19000', 'n/a', '279,144', '38000', '250000000', '6 years', '2.0', '40', 'Star dreadnought', '', 'https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-15T12:31:42.547000Z', '2014-12-20T21:23:49.893000Z', 'https://swapi.dev/api/starships/15/'),
	('7fdf5136-ccdf-425a-b72e-58981cae78d8','Rebel transport', 'GR-75 medium transport', 'Gallofree Yards, Inc.', 'unknown', '90', '650', '6', '90', '19000000', '6 months', '4.0', '20', 'Medium transport', '', 'https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-15T12:34:52.264000Z', '2014-12-20T21:23:49.895000Z', 'https://swapi.dev/api/starships/17/'),
	('cc7cf7aa-8ff0-4f3b-9c58-53eedb0e1a4a','Slave 1', 'Firespray-31-class patrol and attack', 'Kuat Systems Engineering', 'unknown', '21.5', '1000', '1', '6', '70000', '1 month', '3.0', '70', 'Patrol craft', 'https://swapi.dev/api/people/22/', 'https://swapi.dev/api/films/2/,https://swapi.dev/api/films/5/', '2014-12-15T13:00:56.332000Z', '2014-12-20T21:23:49.897000Z', 'https://swapi.dev/api/starships/21/'),
	('1df1e6a9-d086-4cf0-88da-fef2d7c9d8f0','Imperial shuttle', 'Lambda-class T-4a shuttle', 'Sienar Fleet Systems', '240000', '20', '850', '6', '20', '80000', '2 months', '1.0', '50', 'Armed government transport', 'https://swapi.dev/api/people/1/,https://swapi.dev/api/people/13/,https://swapi.dev/api/people/14/', 'https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-15T13:04:47.235000Z', '2014-12-20T21:23:49.900000Z', 'https://swapi.dev/api/starships/22/'),
	('55411fad-40f1-4655-9f40-962a17478a21','EF76 Nebulon-B escort frigate', 'EF76 Nebulon-B escort frigate', 'Kuat Drive Yards', '8500000', '300', '800', '854', '75', '6000000', '2 years', '2.0', '40', 'Escort ship', '', 'https://swapi.dev/api/films/2/,https://swapi.dev/api/films/3/', '2014-12-15T13:06:30.813000Z', '2014-12-20T21:23:49.902000Z', 'https://swapi.dev/api/starships/23/'),
	('b788c3c1-bece-4640-b1de-42cd31da3175','Calamari Cruiser', 'MC80 Liberty type Star Cruiser', 'Mon Calamari shipyards', '104000000', '1200', 'n/a', '5400', '1200', 'unknown', '2 years', '1.0', '60', 'Star Cruiser', '', 'https://swapi.dev/api/films/3/', '2014-12-18T10:54:57.804000Z', '2014-12-20T21:23:49.904000Z', 'https://swapi.dev/api/starships/27/'),
	('3463a0bf-0a7b-4310-8e48-8c814fa32c68','A-wing', 'RZ-1 A-wing Interceptor', 'Alliance Underground Engineering, Incom Corporation', '175000', '9.6', '1300', '1', '0', '40', '1 week', '1.0', '120', 'Starfighter', 'https://swapi.dev/api/people/29/', 'https://swapi.dev/api/films/3/', '2014-12-18T11:16:34.542000Z', '2014-12-20T21:23:49.907000Z', 'https://swapi.dev/api/starships/28/'),
	('3fe69a3b-eb05-412b-8aa0-b06124acb440','B-wing', 'A/SF-01 B-wing starfighter', 'Slayn & Korpil', '220000', '16.9', '950', '1', '0', '45', '1 week', '2.0', '91', 'Assault Starfighter', '', 'https://swapi.dev/api/films/3/', '2014-12-18T11:18:04.763000Z', '2014-12-20T21:23:49.909000Z', 'https://swapi.dev/api/starships/29/'),
	('f958149b-31a2-41ce-84a5-21c9e5e10c37','Republic Cruiser', 'Consular-class cruiser', 'Corellian Engineering Corporation', 'unknown', '115', '900', '9', '16', 'unknown', 'unknown', '2.0', 'unknown', 'Space cruiser', '', 'https://swapi.dev/api/films/4/', '2014-12-19T17:01:31.488000Z', '2014-12-20T21:23:49.912000Z', 'https://swapi.dev/api/starships/31/'),
	('a384b4a6-1795-420b-92a2-fa09c1b7a78e','Droid control ship', 'Lucrehulk-class Droid Control Ship', 'Hoersch-Kessel Drive, Inc.', 'unknown', '3170', 'n/a', '175', '139000', '4000000000', '500 days', '2.0', 'unknown', 'Droid control ship', '', 'https://swapi.dev/api/films/4/,https://swapi.dev/api/films/5/,https://swapi.dev/api/films/6/', '2014-12-19T17:04:06.323000Z', '2014-12-20T21:23:49.915000Z', 'https://swapi.dev/api/starships/32/'),
	('1798e8de-268b-4fed-a243-6cb7da15ddea','Naboo fighter', 'N-1 starfighter', 'Theed Palace Space Vessel Engineering Corps', '200000', '11', '1100', '1', '0', '65', '7 days', '1.0', 'unknown', 'Starfighter', 'https://swapi.dev/api/people/11/,https://swapi.dev/api/people/35/,https://swapi.dev/api/people/60/', 'https://swapi.dev/api/films/4/,https://swapi.dev/api/films/5/', '2014-12-19T17:39:17.582000Z', '2014-12-20T21:23:49.917000Z', 'https://swapi.dev/api/starships/39/'),
	('0df2ba4e-7045-4442-9797-306ea116dd77','Naboo Royal Starship', 'J-type 327 Nubian royal starship', 'Theed Palace Space Vessel Engineering Corps, Nubia Star Drives', 'unknown', '76', '920', '8', 'unknown', 'unknown', 'unknown', '1.8', 'unknown', 'yacht', 'https://swapi.dev/api/people/39/', 'https://swapi.dev/api/films/4/', '2014-12-19T17:45:03.506000Z', '2014-12-20T21:23:49.919000Z', 'https://swapi.dev/api/starships/40/'),
	('7261c10a-175c-4668-9abd-16f115c6dcb0','Scimitar', 'Star Courier', 'Republic Sienar Systems', '55000000', '26.5', '1180', '1', '6', '2500000', '30 days', '1.5', 'unknown', 'Space Transport', 'https://swapi.dev/api/people/44/', 'https://swapi.dev/api/films/4/', '2014-12-20T09:39:56.116000Z', '2014-12-20T21:23:49.922000Z', 'https://swapi.dev/api/starships/41/'),
	('6d22c312-4dcc-4dc4-8a47-370f74398df5','J-type diplomatic barge', 'J-type diplomatic barge', 'Theed Palace Space Vessel Engineering Corps, Nubia Star Drives', '2000000', '39', '2000', '5', '10', 'unknown', '1 year', '0.7', 'unknown', 'Diplomatic barge', '', 'https://swapi.dev/api/films/5/', '2014-12-20T11:05:51.237000Z', '2014-12-20T21:23:49.925000Z', 'https://swapi.dev/api/starships/43/'),
	('165510dd-f570-4776-a49a-5fe6b6179f5c','AA-9 Coruscant freighter', 'Botajef AA-9 Freighter-Liner', 'Botajef Shipyards', 'unknown', '390', 'unknown', 'unknown', '30000', 'unknown', 'unknown', 'unknown', 'unknown', 'freighter', '', 'https://swapi.dev/api/films/5/', '2014-12-20T17:24:23.509000Z', '2014-12-20T21:23:49.928000Z', 'https://swapi.dev/api/starships/47/'),
	('62a060e7-c8fa-45ca-83d5-7fd882cd75bb','Jedi starfighter', 'Delta-7 Aethersprite-class interceptor', 'Kuat Systems Engineering', '180000', '8', '1150', '1', '0', '60', '7 days', '1.0', 'unknown', 'Starfighter', 'https://swapi.dev/api/people/10/,https://swapi.dev/api/people/58/', 'https://swapi.dev/api/films/5/,https://swapi.dev/api/films/6/', '2014-12-20T17:35:23.906000Z', '2014-12-20T21:23:49.930000Z', 'https://swapi.dev/api/starships/48/'),
	('68aa675c-5095-4d6d-ba88-3f8e4ac3aa00','H-type Nubian yacht', 'H-type Nubian yacht', 'Theed Palace Space Vessel Engineering Corps', 'unknown', '47.9', '8000', '4', 'unknown', 'unknown', 'unknown', '0.9', 'unknown', 'yacht', 'https://swapi.dev/api/people/35/', 'https://swapi.dev/api/films/5/', '2014-12-20T17:46:46.847000Z', '2014-12-20T21:23:49.932000Z', 'https://swapi.dev/api/starships/49/'),
	('1cb49ea2-0772-4eae-a956-3a55752320f4','Republic Assault ship', 'Acclamator I-class assault ship', 'Rothana Heavy Engineering', 'unknown', '752', 'unknown', '700', '16000', '11250000', '2 years', '0.6', 'unknown', 'assault ship', '', 'https://swapi.dev/api/films/5/', '2014-12-20T18:08:42.926000Z', '2014-12-20T21:23:49.935000Z', 'https://swapi.dev/api/starships/52/'),
	('885309fa-dacd-4a9d-917b-3465c6c3771b','Solar Sailer', 'Punworcca 116-class interstellar sloop', 'Huppla Pasa Tisc Shipwrights Collective', '35700', '15.2', '1600', '3', '11', '240', '7 days', '1.5', 'unknown', 'yacht', '', 'https://swapi.dev/api/films/5/', '2014-12-20T18:37:56.969000Z', '2014-12-20T21:23:49.937000Z', 'https://swapi.dev/api/starships/58/'),
	('5fa0098b-1581-4cd1-948a-0a9a580627ed','Trade Federation cruiser', 'Providence-class carrier/destroyer', 'Rendili StarDrive, Free Dac Volunteers Engineering corps.', '125000000', '1088', '1050', '600', '48247', '50000000', '4 years', '1.5', 'unknown', 'capital ship', 'https://swapi.dev/api/people/10/,https://swapi.dev/api/people/11/', 'https://swapi.dev/api/films/6/', '2014-12-20T19:40:21.902000Z', '2014-12-20T21:23:49.941000Z', 'https://swapi.dev/api/starships/59/'),
	('df042d36-841b-4b22-8759-942a42e41a0d','Theta-class T-2c shuttle', 'Theta-class T-2c shuttle', 'Cygnus Spaceworks', '1000000', '18.5', '2000', '5', '16', '50000', '56 days', '1.0', 'unknown', 'transport', '', 'https://swapi.dev/api/films/6/', '2014-12-20T19:48:40.409000Z', '2014-12-20T21:23:49.944000Z', 'https://swapi.dev/api/starships/61/'),
	('95ad7280-9778-4c22-9d43-2603a2a5def5','Republic attack cruiser', 'Senator-class Star Destroyer', 'Kuat Drive Yards, Allanteen Six shipyards', '59000000', '1137', '975', '7400', '2000', '20000000', '2 years', '1.0', 'unknown', 'star destroyer', '', 'https://swapi.dev/api/films/6/', '2014-12-20T19:52:56.232000Z', '2014-12-20T21:23:49.946000Z', 'https://swapi.dev/api/starships/63/'),
	('e6f09a1b-fec6-41bc-8ced-c24a4c00bd6a','Naboo star skiff', 'J-type star skiff', 'Theed Palace Space Vessel Engineering Corps/Nubia Star Drives, Incorporated', 'unknown', '29.2', '1050', '3', '3', 'unknown', 'unknown', '0.5', 'unknown', 'yacht', 'https://swapi.dev/api/people/10/,https://swapi.dev/api/people/35/', 'https://swapi.dev/api/films/6/', '2014-12-20T19:55:15.396000Z', '2014-12-20T21:23:49.948000Z', 'https://swapi.dev/api/starships/64/'),
	('df80cc09-2c09-4de5-a16c-9331fc0c85bb','Jedi Interceptor', 'Eta-2 Actis-class light interceptor', 'Kuat Systems Engineering', '320000', '5.47', '1500', '1', '0', '60', '2 days', '1.0', 'unknown', 'starfighter', 'https://swapi.dev/api/people/10/,https://swapi.dev/api/people/11/', 'https://swapi.dev/api/films/6/', '2014-12-20T19:56:57.468000Z', '2014-12-20T21:23:49.951000Z', 'https://swapi.dev/api/starships/65/'),
	('9867c16e-3d52-4bae-bf40-86c1cf4b8062','arc-170', 'Aggressive Reconnaissance-170 starfighte', 'Incom Corporation, Subpro Corporation', '155000', '14.5', '1000', '3', '0', '110', '5 days', '1.0', '100', 'starfighter', '', 'https://swapi.dev/api/films/6/', '2014-12-20T20:03:48.603000Z', '2014-12-20T21:23:49.953000Z', 'https://swapi.dev/api/starships/66/'),
	('f6bb5671-eeb8-4e32-8f7b-da6cb7b64fa4','Banking clan frigte', 'Munificent-class star frigate', 'Hoersch-Kessel Drive, Inc, Gwori Revolutionary Industries', '57000000', '825', 'unknown', '200', 'unknown', '40000000', '2 years', '1.0', 'unknown', 'cruiser', '', 'https://swapi.dev/api/films/6/', '2014-12-20T20:07:11.538000Z', '2014-12-20T21:23:49.956000Z', 'https://swapi.dev/api/starships/68/'),
	('4fd503df-037b-4623-9a1d-c1814113c5d3','Belbullab-22 starfighter', 'Belbullab-22 starfighter', 'Feethan Ottraw Scalable Assemblies', '168000', '6.71', '1100', '1', '0', '140', '7 days', '6', 'unknown', 'starfighter', 'https://swapi.dev/api/people/10/,https://swapi.dev/api/people/79/', 'https://swapi.dev/api/films/6/', '2014-12-20T20:38:05.031000Z', '2014-12-20T21:23:49.959000Z', 'https://swapi.dev/api/starships/74/'),
	('135dd4ef-f063-4b6d-bc5a-22e1ddf346e3','V-wing', 'Alpha-3 Nimbus-class V-wing starfighter', 'Kuat Systems Engineering', '102500', '7.9', '1050', '1', '0', '60', '15 hours', '1.0', 'unknown', 'starfighter', '', 'https://swapi.dev/api/films/6/', '2014-12-20T20:43:04.349000Z', '2014-12-20T21:23:49.961000Z', 'https://swapi.dev/api/starships/75/');