import { Component, OnInit } from '@angular/core';
import { RezultatService } from '../services/rezultat.service';

@Component({
  selector: 'app-rezultate',
  templateUrl: './rezultat.component.html',
  styleUrls: ['./rezultat.component.css']
})
export class RezultateComponent implements OnInit {
  rezultate: any[] = [];

  constructor(private rezultatService: RezultatService) { }

  ngOnInit() {
    this.rezultatService.getRezultate().subscribe(data => {
      this.rezultate = data;
    });
  }
}