namespace HCA;

public class Processor {
    public string Model { get; set; }
    public Processor(string model) {
        Model = model;
    }
    public override string ToString() {
        return $"Processor: {Model}";
    }
}

public class Notebook {
    public string Brand { get; set; }
    public Processor Processor { get; set; } 

    public Notebook(string brand, string processorModel) {
        Brand = brand;
        Processor = new Processor(processorModel); 
    }
    public override string ToString() {
        return$"Notebook[Brand={Brand}, Processor={Processor.Model}]";
    }
}
