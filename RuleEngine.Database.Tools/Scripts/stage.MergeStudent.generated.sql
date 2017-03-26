CREATE PROCEDURE [stage].[MergeStudent]
AS
BEGIN
 
        SET NOCOUNT ON;
 
        MERGE dbo.[Student] AS TARGET
        USING stage.[Student] AS SOURCE
        ON
			    TARGET.[Id] = SOURCE.[Id]
		WHEN MATCHED THEN
		UPDATE SET
				 TARGET.[FirstName] = SOURCE.[FirstName]
				,TARGET.[LastName] = SOURCE.[LastName]
		WHEN NOT MATCHED THEN
		INSERT(
				 [Id]
				,[FirstName]
				,[LastName]
		)
		VALUES(
				 SOURCE.[Id]
				,SOURCE.[FirstName]
				,SOURCE.[LastName]
		
		);
END  
