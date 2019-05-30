create trigger AtualizarEstoque_Venda 
on itensVenda
after insert
as
Begin
set nocount on;
	Update P set P.EstoqueAtual = P.EstoqueAtual - i.Quantidade From Produto P inner join ItensVenda i on i.Id_Produto = p.Id_Produto
end
