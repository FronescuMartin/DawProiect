import { Component, OnInit } from '@angular/core';
import { PersoanaService } from '../services/persoana.service';

@Component({
  selector: 'app-persoane',
  templateUrl: './persoana.component.html',
  styleUrls: ['./persoana.component.css']
})
export class PersoaneComponent implements OnInit {
  persoane: any[] = [];

  constructor(private PersoanaService: PersoanaService) { }

  ngOnInit() {
    this.PersoanaService.getPersoane().subscribe(data => {
      this.persoane = data;
    });
  }
}

