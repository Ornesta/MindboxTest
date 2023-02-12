select products.[name], categories.[name]
from [products] p
left join [products_categories] AT ON AT.[product_id] = p.[id]
left join [categories] c ON c.id = AT.[category_id]