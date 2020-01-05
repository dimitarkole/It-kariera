Use geography;


Select country_name,
max(p.elevation) as highest_peak_elevation,
max(r.length) as longest_river_length
from countries as c
Inner Join countries_rivers as cr On c.country_code=cr.country_code
Inner Join rivers as r On cr.river_id = r.id

Inner Join mountains_countries as mc On c.country_code=mc.country_code
Inner Join mountains as m On mc.mountain_id = m.id
Inner Join peaks as p On m.id = p.mountain_id

GROUP BY country_name
Order by highest_peak_elevation desc,
longest_river_length desc,
country_name asc
LIMIT 5;