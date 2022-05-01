create procedure markagetirsin--burda prosedür ismi veriyoruz 
as-- 
select TOP 1  marka from tblurun group by marka order by COUNT(*) desc