USE `gringotts`;

Select deposit_group,
MAX(magic_wand_size) as longest_magic_wand 
from wizzard_deposits 
GROUP BY deposit_group
ORDER BY longest_magic_wand asc, deposit_group asc;

Select deposit_group
from wizzard_deposits 
GROUP BY deposit_group
ORDER BY AVG(magic_wand_size) asc, deposit_group asc
Limit 1;

Select * from wizzard_deposits
Limit 2;

Select deposit_group,
sum(deposit_amount) as total_sum 
from wizzard_deposits 
GROUP BY deposit_group
ORDER BY total_sum asc;