//
// nome do programa: EX_5_1.java
//
// programadores: nome dos alunos
// Mateus Fernando          484555
// Vinicius Ponciano        482955
// Yitzhak Stone            478493
// data: 30/04/2015
// descricao:
// programa pesquisa em um intervalo fechado de números inteiros
// [MIN ... MAX] , ou seja, delimitado pelos valores inteiros MIN e MAX recebidos
// através de parâmetros na linha de comando, e imprimir os números que são
// simultaneamente ímpar, múltiplo de 7 e não múltiplo de 5. 
// Exemplo (com: MIN = 2 e MAX = 10):
// ENTRADA: EX_2_2.class 2 10
// SAIDA: 7
// 

class EX_5_1 {
    public static void main(String[] args) 
    {
        
        System.out.println("484555\t\tMateus Fernando");
        System.out.println("482955\t\tVinicius Ponciano");
        System.out.println("478493\t\tYitzhak Stone");
        System.out.println();


        try
        {

            int l = args.length;
            
            if (l != 2)
            {            
                System.out.println("Argumentos invalidos!");
                return;
            }

            int n1 = Integer.parseInt(args[0]);
            int n2 = Integer.parseInt(args[1]);

            for (int i = n1 + 1; i < n2 ; i++) {
                if (impar(i) && !multiplo5(i) && multiplo7(i)){
                    System.out.print(i + ", ");
                }
            }
        } 
        catch (Exception ex)
        {
            System.out.println("Argumentos invalidos!");
        }

        System.out.println();
        System.exit(0);

    }


    public static boolean impar(int n)
    {
        return (n%2==1);
    }

    public static boolean multiplo5(int n)
    {
        return (n%5==0);
    }

    public static boolean multiplo7(int n)
    {
        return (n%7==0);
    }
} 