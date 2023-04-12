SELECT stud_name as [First name], stud_surname as [Second name], stud_birthday as [Born], 
subj_name as [Name of subject] FROM students st LEFT JOIN
stud_subj ss ON st.stud_id = ss.stud_id LEFT JOIN subjects sb ON sb.subj_shrt = ss.subj_shrt

SELECT stud_surname as [Second name] , count(stud_surname) as [Occurences] FROM students GROUP BY stud_surname

SELECT subj_name as [Name of subject], count(stud_subj.subj_shrt) as [Occurences] FROM stud_subj 
LEFT JOIN subjects st ON stud_subj.subj_shrt = st.subj_shrt 
GROUP BY subj_name HAVING COUNT(stud_subj.subj_shrt) < 3

SELECT stud_subj.subj_shrt as [Subject shortening], COUNT(stud_subj.subj_shrt) as [Number of students], 
MAX(subj_ratings.rating_num) as [Best rating], MIN(subj_ratings.rating_num) as [Worst rating], AVG(subj_ratings.rating_num) as [Average rating] 
FROM stud_subj LEFT JOIN subj_ratings ON stud_subj.stud_id = subj_ratings.stud_id 
GROUP BY stud_subj.subj_shrt 
HAVING stud_subj.subj_shrt IS NOT NULL 
ORDER BY [Number of students] DESC;