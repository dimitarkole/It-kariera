USE `gringotts`;

SELECT deposit_group,
magic_wand_creator,
min(deposit_charge) AS min_deposit_charge 
from wizzard_deposits
GROUP BY deposit_group,magic_wand_creator
order by magic_wand_creator asc,
deposit_group asc;

SELECT (case
	When age BETWEEN 0 and 10 then '[0-10]'
    When age BETWEEN 11 and 20 then '[11-20]'
    When age BETWEEN 21 and 30 then '[21-30]'
    When age BETWEEN 31 and 40 then '[31-40]'
    When age BETWEEN 41 and 50 then '[41-50]'
    When age BETWEEN 51 and 60 then '[51-60]'
    When age > 60 then '[60+]'
END) as age_group,
count(id) as wizard_count from wizzard_deposits
GROUP BY age_group
order by wizard_count;


SELECT deposit_group,
magic_wand_creator,
min(deposit_charge) AS min_deposit_charge 
from wizzard_deposits
GROUP BY deposit_group,magic_wand_creator
order by magic_wand_creator asc,
deposit_group asc;



SELECT SUBSTRING(magic_wand_creator,1,1) AS first_letter 
from wizzard_deposits
where deposit_group="Troll Chest"
GROUP BY magic_wand_creator;
