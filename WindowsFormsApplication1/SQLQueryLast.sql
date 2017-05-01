/*drop view allData;*/
/*alter view allData (typeDetail, nameDetail, unit, unitPrice, finishedCode, operationCode, componenetCount, jobCode, categoryCode, tariffCode, preparationTime, partCreatingTime) as
select typeDetail, nameDetail, unit, unitPrice, finishedCode, lab.operationCode, componentCount, jobCode, categoryCode, tariffCode, preparaionTime, partCreatingTime 
from dbo.Details as det
join labourInput as lab  on lab.detailCode = det.id
join Assembly as assem  on (assem.componentCode=lab.detailCode and assem.operationCode=lab.operationCode);*/
/*create view allData (id)
as
select id from [dbo].[Details]*/
/*select * from allData;*/
insert into Details (typeDetail, nameDetail, unit, unitPrice) 
values (1, 'Двигатель', 'шт', 10000), 
(1, 'Карбюратор', 'шт', 1000), 
(1, 'Шина', 'шт', 500),
(1, 'Свечи', 'шт', 50),
(1, 'Кузов', 'шт', 20000)