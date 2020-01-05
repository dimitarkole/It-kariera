use buhtig_source_control;
/*
Select id, username 
from users 
ORDER BY id;

Select repository_id, contributor_id
from repositories_contributors
WHERE repository_id = contributor_id
order by repository_id;


Select i.id, concat(u.username, " : ", i.title) as issue_assignee
from issues  as i
Inner Join users as u On i.assignee_id=u.id
Order by i.id Desc;


SELECT id, name, concat(size,"KB") as size
FROM files f WHERE (SELECT count(id) FROM files 
   WHERE files.parent_id = f.id) = 0;
   
SELECT r.Id, r.name, count(i.Id) as issues from issues as i
INNER Join repositories as r On i.repository_id=r.id
GROUP BY r.Id
order by issues desc,  r.id asc
limit 5;
*/

SELECT 
 r.id as id,
 r.name,
 (Select count(id) 
	from  commits as c
	where c.repository_id=r.id) as users
from repositories as r
GROUP BY r.name
Order by users desc, id asc;
