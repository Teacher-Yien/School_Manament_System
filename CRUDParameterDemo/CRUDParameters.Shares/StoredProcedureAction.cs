namespace EnrollLibrary
{
    public class StoredProcedureAction
    {
        public Procedure ReadAll { get; set; } = default!;
        public Procedure ReadById { get; set; } = default!;
        public Procedure Insert { get; set; } = default!;
        public Procedure Update { get; set; } = default!;
        public Procedure Delete { get; set; } = default!;
    }
}