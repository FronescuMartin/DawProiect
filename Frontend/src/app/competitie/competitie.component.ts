import { Component, OnInit } from '@angular/core';
import { CompetitieService } from '../services/competitie.service';

@Component({
  selector: 'app-competitie',
  templateUrl: './competitie.component.html',
  styleUrls: ['./competitie.component.css']
})
export class CompetitieComponent implements OnInit {
  competities: any[] = [];

  constructor(private competitieService: CompetitieService) { }
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

  /*ngOnInit() {
    this.competitieService.getCompetitie().subscribe(data => {
      this.competities = data;
    });
  }*/
}