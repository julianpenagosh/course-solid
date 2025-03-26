using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper.Export(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");