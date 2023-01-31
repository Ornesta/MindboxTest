select P.[Name], C.[Name]
from [Products] P
left join [ProductNames] AT ON AT.[ProductId] = P.[Id]
left join [Category] C ON C.[Id] = AT.[CategoryId]