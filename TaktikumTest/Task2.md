Задача 2

1.
select Clients.ClientName, Count(ClientContacts.Id) as "Кол-во контактов" 
from Clients
left join clientContacts on clients.id = clientcontacts.clientid
group by Clients.Id

2.
select Clients.ClientName from Clients
left join clientContacts on clients.id = clientcontacts.clientid
group by Clients.Id
having Count(ClientContacts.Id) > 2
