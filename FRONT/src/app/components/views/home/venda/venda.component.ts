import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
    selector: "app-venda",
    templateUrl: "./venda.component.html",
    styleUrls: ["./venda.component.css"],
})
export class VendaComponent implements OnInit {

    constructor( private router: Router) {}

    ngOnInit(): void { }

}
