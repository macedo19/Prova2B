import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { ItemVenda } from "src/app/models/item-venda";
import { Produto } from "src/app/models/produto";
import { Venda } from "src/app/models/venda";
import { ItemService } from "src/app/services/item.service";
import { ProdutoService } from "src/app/services/produto.service";

@Component({
    selector: "app-venda",
    templateUrl: "./venda.component.html",
    styleUrls: ["./venda.component.css"],
})
export class VendaComponent implements OnInit {
    produtos: Produto[] = [];

    constructor(
        private produtoService: ProdutoService,
        private itemService: ItemService,
        private router: Router
    ) {}

    ngOnInit(): void {
        this.produtoService.list().subscribe((produtos) => {
            this.produtos = produtos;
        });
    }

    adicionarVenda(venda: Venda): void {
        let itemVenda: Venda = {
            cliente: venda.cliente,
            itens: venda.itens!,
            pagamento: venda.pagamento,
        };
        this.itemService.create(item).subscribe((item) => {
            localStorage.setItem("carrinhoId", item.carrinhoId);
            this.router.navigate(["home/carrinho"]);
        });
    }

}
