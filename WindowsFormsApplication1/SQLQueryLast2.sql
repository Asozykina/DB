select det.nameDetail, COUNT (*) as countOfComponent from Assembly as assem, Details as det
where (finishedCode=det.id or componentCode=det.id) GROUP BY det.nameDetail