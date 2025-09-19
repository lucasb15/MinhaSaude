# 🩺 MinhaSaude

📌 Aplicativo pessoal para gerenciar informações de dieta, água, exercícios e saúde em geral.
O objetivo é acompanhar alimentação, treinos, sono e metas nutricionais de forma estruturada.

Atualmente, o projeto será desenvolvido em C# + SQL Server, com WinForms como interface inicial.
No futuro, a ideia é evoluir para aplicativo mobile.

## 🧠 Arquitetura

O projeto está dividido em camadas, seguindo boas práticas de separação de responsabilidades:

MinhaSaude.Core → Contém todas as classes e abstrações.

MinhaSaude.Data → Responsável pela persistência (Entity Framework + SQL Server).

MinhaSaude.API → (em construção futura) Exposição dos dados via API para integração com aplicativos.

## 🥗 Alimentos e Receitas

Alimento: representa um item individual (ex: arroz, frango, ovo).

Cada alimento possui 1:1 relação com sua TabelaNutricionalAlimento.

Pode conter tags (ex: "low carb", "sem glúten").

Receita: conjunto de ingredientes que formam um prato.

Sua tabela nutricional é calculada dinamicamente a partir dos ingredientes.

Usa a TabelaNutricionalReceita.

## 📊 Tabelas Nutricionais

Criadas a partir da classe abstrata TabelaNutricionalBase, que centraliza nutrientes principais (calorias, proteínas, carboidratos, gorduras, sódio, fibras).

Variações:

TabelaNutricionalAlimento → associada a alimentos.

TabelaNutricionalReceita → associada a receitas.

TabelaNutricionalConsumida → usada como histórico do que foi ingerido pelo usuário.

Nutrientes adicionais ficam em:

Onde possui relação 1:N relação com sua tabela.

TabelaNutricionalOutros

TabelaNutricionalConsumidaOutros (para histórico).

## 🏆 Metas e Consumo

Metas → objetivos de consumo/calorias/água/sono em um período.

MetaDiaria → acompanha se o usuário cumpriu ou não as metas em cada dia.

ConsumoDiario → registra alimentos ou receitas consumidos no dia, junto da tabela nutricional consumida.

## 🩺 Monitoramento de Saúde

ConsumoAgua → litros ingeridos por dia.

Sono → horas dormidas.

Exercicios → treinos e atividades físicas.

Medidas → peso, altura, circunferências etc.

## ⚙️ Auxiliares

UnidadeAux → unidades de medida (g, ml, colher, fatia).

TipoNutrienteAux → classifica nutrientes (macro, vitamina, mineral).

NutrienteRegistroAux → lista de nutrientes adicionais. (Vitamina B3, TipoNutrienteAux sendo a Vitamina).

Tags → categorias para alimentos.

AlimentoTag → relacionamento N:N entre alimentos e tags.

DietaItem → define a dieta planejada (Basicamente falar qual a dieta que a nutricionista passou, para assim toda vez que colocar o que consumi o sistema saber se faz parte da dieta ou não).

MomentoConsumo → organiza refeições (café da manhã, almoço, jantar).

Log → registro de alterações (auditoria). (Implementação futura, queria entender como funciona os logs e como posso registrar, chat diz que o proprio entity consegue criar, mas....)

## ⚖️ Regras de Negócio (atuais e futuras)

Quando um Alimento for alterado, todas as Receitas que usam ele como ingrediente devem ter suas tabelas nutricionais recalculadas automaticamente.

Metas devem ser avaliadas diariamente, gerando registros de sucesso ou falha (ex: não bateu meta de água). (Inicialmente as metas seria avaliada quando o usuario requisitar por determinado periodo, mas ainda avaliando)

O consumo diário deve alimentar tanto o histórico do usuário quanto a verificação de metas.

Logs devem registrar toda criação, alteração e exclusão de itens importantes.
