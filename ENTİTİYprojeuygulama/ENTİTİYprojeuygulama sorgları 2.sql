create procedure markagetirsin--burda prosed�r ismi veriyoruz 
as-- 
select TOP 1  marka from tblurun group by marka order by COUNT(*) desc