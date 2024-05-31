namespace EnrollLibrary
{
    public class StoredProcedureSetting
    {
        public StoredProcedureAction StudentStoredProcedureAction { get; set; } = default!;
        public StoredProcedureAction CourseStoredProcedureAction { get; set; } = default!;
        public StoredProcedureAction EnrollingStoredProcedureAction { get; set; } = default!;
    }
}