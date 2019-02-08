SELECT FirstName, City, Country
FROM People
ORDER BY
(
CASE
    WHEN City IS NULL THEN Country
    ELSE City
END
)