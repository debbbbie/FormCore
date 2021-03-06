﻿namespace FormCore {
  public class OSection {
    public OSection(Section instance) {
      Id = instance.Id;
      ParentId = instance.ParentId;
      FormId = instance.FormId;
      Position = instance.Position;
      Title = instance.Title;
    }

    public int Id { get; set; }
    public int ParentId { get; set; }
    public int FormId { get; set; }
    public double Position { get; set; }
    public string Title { get; set; }
  }
}